using System;
using System.Collections;
using System.Collections.Generic;

namespace StackT
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Person> person = new Stack<Person>();

            person.Push(new Person() { Name = "Peter" });
            person.Push(new Person() { Name = "Alex" });
            person.Push(new Person() { Name = "Polina" });
            foreach(Person p in person)
            {
                Console.WriteLine(p.Name);
            }
            Person PersonFromStack = person.Pop();
            Console.WriteLine("\n"+PersonFromStack.Name+"\n");

            foreach (Person p in person)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
}
//Push: добавляет элемент в стек на первое место

//Pop: извлекает и возвращает первый элемент из стека

//Peek: просто возвращает первый элемент из стека без его удаления