namespace Refresher.Entities
{

    /// <summary>
    /// The response class is used by handler methods that may communicate through API or other means.
    /// It contains a success flag and message variables for further context.
    /// </summary>
    public class Response
    {

        public string message;
        public Boolean success;
        public object other;

        public Response(string message, Boolean success, object other)
        {
            this.message = message;
            this.success = success;
            this.other = other;

        }

        public Response(string message, Boolean success)
        {
            this.message = message;
            this.success = success;
        }

        public Response(Boolean success)
        {
            this.success = success;
        }
    }
}
