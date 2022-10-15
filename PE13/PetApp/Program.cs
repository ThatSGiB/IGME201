using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    public interface ICat
    {
        void Eat()
        {

        }
        void Play()
        {

        }
        void Scracth()
        {

        }
        void Purr()
        {

        }
    }

    public class Cat : Pet, ICat
    {
        public void Eat()
        {

        }
        public void Play()
        {

        }
        public void Purr()
        {

        }
        public void Scratch()
        {

        }
        public void GotoVet()
        {

        }
    }
    public abstract class Pet
    {
        public string name;
        public int age;
        public string Name;
        public abstract void Eat();
        public abstract void Play();
        public abstract void GotoVet();
    }

    public class Dog: Pet
    {
        public string license;
        public void Eat();
        public void Play();
        public void Bark();
        public void NeedWalk();
        public void GotoVet();
    }
}
