

namespace FusionTech.src.Utils
{
    public class CustomExeption : Exception
    {
        public int StatusCode { get; set; }
        public CustomExeption(int statusCode, string message) : base(message)
        {
            StatusCode = statusCode;
        }
        public static CustomExeption NotFound(string message = "Item not found")
        {
            return new CustomExeption(404, message);
        }

        public static CustomExeption BadRequest(string message = "Bad request")
        {
            return new CustomExeption(400, message);
        }

        public static CustomExeption UnAthorized(string message = "Unauthrized. Please log in")
        {
            return new CustomExeption(401, message);
        }

        public static CustomExeption InternalError(string message = "Internal server error")
        {
            return new CustomExeption(500, message);
        }
        
        public static CustomExeption Forbidden(string message = "Forbidden. The user does not have access rights to the requested resource.")
        {
            return new CustomExeption(403, message);
        }

    }
}