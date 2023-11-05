

using Indexe_Exception_Practice;
using Indexe_Exception_Practice.Controller;
using Indexe_Exception_Practice.Exceptions;
using Indexe_Exception_Practice.Helpers.Constant;

//Library library = new Library();

//Book book = new Book();
//book.Id = 1;

//book.Name = "Test1";

//library[0] = book;

//Console.WriteLine(library[0].Name);


//int a = 5;

//int b = 0;

//int result = a / b;

//Console.WriteLine(result);

//try
//{

//    int a = 5;

//    int b = 0;

//    int result = a / b;

//    Console.WriteLine(result);

//}
//catch (Exception ex)
//{

//    Console.WriteLine(ex.Message);

//}




//try
//{
//    int[] nums = new int[0];
//    nums[2] = 100;

//    int a = 5;

//    int b = 0;

//    int result = a / b;

//    Console.WriteLine(result);

//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (NullReferenceException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    Console.WriteLine("Salam Aleykum");
//}



static void Register(string userName, string password)
{
	try
	{
        if (userName == "haci123")
        {
            Console.WriteLine("Register success");
        }
        else
        {
            throw new RegisterFailedException("Cox sagolun");
        }
    }
	catch (Exception ex)
	{

        Console.WriteLine(ex.Message);
    }
    finally
    {
        SendEmail(true);
    }
}



//Register("haci12", "sdafs");

static void SendEmail(bool isScucces)
{
    if (isScucces)
    {
        Console.WriteLine(AccountMessages.RegisterEmailSuccess);
    }
    else
    { 
        Console.WriteLine(AccountMessages.RegisterEmailFail);
    }
    
  
}

//ShowText(null);

//static void ShowText(string text)
//{
//    try
//    {
//        if (text is null)
//        {
//            throw new ArgumentNullException();
//        }
//        else
//        {
//            Console.WriteLine(text);
//        }
//    }
//    catch (Exception ex)
//    {

//        Console.WriteLine(ex.Message); 
//    }
   
//}

PersonController personController = new PersonController();
personController.GetById();
