using lez03_10_Object.classes;

namespace lez03_10_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona per = new Persona();
            Studente stu = new Studente();

            //Object è la superclasse madre ed ogni altra classe eredita da lei
            List<Object> list = new List<Object>();
            list.Add(per);
            list.Add(stu);
            list.Add("PIPPO");

            Persona gio = new Studente() //LE GRAFFE INDICANO IL COSTRUTTORE DI PERSONA
            {
                Nominativo = "Valeria"
            };
            Console.WriteLine(gio.ToString());

        }
    }
}
