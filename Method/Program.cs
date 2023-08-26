//Метод 1
/*void Method1()
{
    Console.WriteLine ("Автор : Карасёв Александр");
}

Method1();
*/

//Метод 2
/*void Method2(string msg, int count) {
Console.WriteLine (msg);
int i=0; 
while  (i<count) {
    Console.WriteLine(msg);
    i++;
}
}

Method2(count :4, msg : "Текст сообщения");
*/














//Метод 3
/*int Method3 () {
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine (year);
*/

// Метод 4 
/*string Metod4(int count, string text)
{
int i = 0;
string result = String.Empty;
while (i<count)
{
result = result + text;
i++;
}
return result;
}
string res = Metod4(10, "asdf");
Console.WriteLine(res);
*/


//Метод 4 с циклом for 

string MetodFor(int count, string text) {
    string resualt = String.Empty;
    for (int i=0; i<count; i++) {
resualt = resualt +text;
    }
    return resualt;
}

string res=MetodFor(10,"z");
Console.WriteLine(res);