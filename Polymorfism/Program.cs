namespace Polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<UserError> errorList = new List<UserError>();

            errorList.Add(new NumericInputError());
            errorList.Add(new NumericInputError());
            errorList.Add(new TextInputError());
            errorList.Add(new TextInputError());
            errorList.Add(new UnsignedIntInputError());
            errorList.Add(new UnsignedIntInputError());
            errorList.Add(new ByteInputError());
            errorList.Add(new ByteInputError());
            errorList.Add(new IntegerInputError());
            errorList.Add(new IntegerInputError());

            foreach (UserError error in errorList)
            {
                Console.WriteLine(error.UEmessage());
            }
        }
    }
}
