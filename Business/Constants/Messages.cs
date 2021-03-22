using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constant
{
    public static class Messages
    {
        public static string MaintenanceTeam = "The system is under maintenance";
        public static string Updated = "Update completed successfully";

        public static string CarAdded = "New car added";
        public static string CarDailyPriceInvalid = "The car name must be at least 2 characters";
        public static string CarDeleted = "The car deleted";
        public static string CarListed = "Cars listed";

        public static string BrandAdded = "New brand added";
        public static string BrandDeleted = "The brand deleted";
        public static string BrandListed = "Brands listed";
        public static string BrandListedById = "Brands listed by Id number";

        public static string ColorAdded = "New color added";
        public static string ColorDeleted = "The color deleted";
        public static string ColorListed = "Brands listed";
        public static string ColorListedById = "Colors listed by id number";

        public static string RentalAdded = "Rental information added";
        public static string RentalInvalid = "Rent another car please";
        public static string RentalListed = "Rental information listed";

        public static string CustomerAdded = "New customer added";
        public static string CustomerDeleted = "The customer deleted";
        public static string CustomerListed = "Customers listed";
        public static string CustomerListedById = "Customers listed by id number";

        public static string UserAdded = "New user added";
        public static string UserListed = "Users listed";
        public static string UserListedById = "Users listed by id number";
        
        internal static string CarCheckImageLimited="";
        internal static string CarImagesListed="Card images listed";
        internal static string CarImageAdded="New car image added";
        internal static string CarImageDeleted="The car image deleted";

        internal static string AuthorizationDenied= "You aren't authorized";
        internal static string UserAlreadyExists;
        internal static string SuccessfulLogin;
        internal static string PasswordError;
        internal static string UserNotFound;
        internal static string UserRegistered;
        internal static string AccessTokenCreated;
    }
}
