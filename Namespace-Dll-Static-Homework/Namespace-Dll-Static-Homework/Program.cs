using Namespace_Dll_Static_Homework;
using Namespace_Dll_Static_Homework.Controllers;
using Namespace_Dll_Static_Homework.Helpers.Extensions;

//2 eded extension method yazirsiz. Biri emailin icinde @ isaresinin olub olmamasini yoxlamalidir.
//Digeri passwordun uzunluqunun 8den boyuk olub olmadigini yoxlamalidir.

string email = "test@gmail.com";

//Console.WriteLine(email.IsValid());


string password = "kamran12345";

//Console.WriteLine(password.CheckPasswordLength());


//int arrayi ucun extention method yazirsiz.
//Hemin extention method arrayin elementlerinin hasilini tapsin.

int[] arr = { 2, 3, 4, 5, 6 };

//Console.WriteLine(arr.ProductOfElems());




//CalculatorService adinda class yaradirsiz, hemin classin icinde Calculation metodunuz olur.
//Method 2 parametr qebul edir. 4 emeliyyati (+,-,*,/)hesablayan calculator olacaq.
//Reqemler ve operatorlar console-dan daxil edilmelidir. Uygun controller de olsun.

CalculatorController calculatorController = new CalculatorController();

calculatorController.Calculation();

