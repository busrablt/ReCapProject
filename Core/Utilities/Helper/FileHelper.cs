using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concreate;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helper
{
    public class FileHelper
    {
        public static string Add(IFormFile file)
        {
            var result = newPath(file);
            var sourcePath = Path.GetTempFileName();
            if (file.Length > 0)
            {
                using (var stream = new FileStream(sourcePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                File.Move(sourcePath, result.newPath);  
            }
            return result.Path2;
        }

        public static string Update(string sourcePath, IFormFile file)
        {
            var result = newPath(file);
            if (sourcePath.Length > 0)
            {
                using (var stream = new FileStream(result.newPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            File.Delete(sourcePath);
            return result.Path2;
        }

        public static IResult Delete(string path)
        {
            File.Delete(path);
            return new SuccessResult();
        }

        public static (string newPath, string Path2) newPath(IFormFile file)
        {
            FileInfo ff = new FileInfo(file.FileName);
            string fileExtension = ff.Extension;
            var newPath = Guid.NewGuid() + fileExtension;
            string path = Environment.CurrentDirectory + @"\wwwroot\Images";
            string result = $@"{path}\{newPath}";
            return (result, $"\\Images\\{newPath}");
        }
    }

}


