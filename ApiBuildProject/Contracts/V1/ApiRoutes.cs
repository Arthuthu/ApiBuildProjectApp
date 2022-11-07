using Microsoft.AspNetCore.Mvc;

namespace ApiBuildProject.Contracts.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";

        public const string Version = "v1";


        public static class Users
        {
            public const string Route = $"{Root}/{Version}/[controller]";
        }
    }
}
