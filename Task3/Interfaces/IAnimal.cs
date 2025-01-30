using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Interfaces
{

    //public interface IAnimal or internal interface IAnimal only allowed other not. 
    //interface can inherit from another interface too
    // Cannot create instance of an interface but can create reference 

    interface IAnimal
    {
        //Default Scope of Interface member is public by default (private in case of normal class ) & abstract
        // We cannot declare field , variable and constructor in interface e.g int x
        // No need to write override modifier just like abstract class
        void MakeSound();

        string GetSpecies();



    }
}
