namespace User_API.Utils
{
    public static class Method
    {

        private static int _id = 0;

        public static int IncrementId()
        {
            return ++_id;
        }
    }
}
