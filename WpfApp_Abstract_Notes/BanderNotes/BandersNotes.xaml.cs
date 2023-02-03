using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_Abstract_Notes.BanderNotes
{
    /// <summary>
    /// Interaction logic for BandersNotes.xaml
    /// </summary>
    public partial class BandersNotes : Page
    {
        public BandersNotes()
        {
            InitializeComponent();

            //MY NOTES for the Abstract chapter

            // While using the Visual Studio app to develop a C# Wpf Project,
            //if you accidentally lose one of your windows, click the Window-
            //Column at the top of the App and then click "Reset Window Layout"

            // A static constructor only runs ONCE and once and item from the 

            // Our New Wpf App will first run the code from MainWindow.xaml.cs.

            // Our initial base parent class of code for our project:

            // MainWindow.xaml.cs (File)

            /*
            InitializeComponent();
            
            // Observable Collection
            // To attach an ObservableCollection to a Selection Box, Attach it to the ItemsSource
            
            lbDisplay.ItemsSource = products;


            */


            // Then we create the following new class objects to store
            //more detailed child data that refers back to our original
            //base parent class object's details


            // Product.cs (file)
            /*
             // The Product Class is where we will use an Abstract class,
            //an Abstract class is used to create a general class that
            //others can inherit from, but you can make an instance of directly
            
             // First, I wrote all of my instance details out for Product
             //that I convert to a constructor by highlighting the instance details
             //and right clicking on the highlighted data and then choose constructor.
             
            // Next, I gave our app some default data to display on our listbox when the App runs
            void Preload()
            {
            products.Add(new ColdDrink([insert details for all 3 parameters of child class added to our listbox]);
            products.Add(new BakedGood([insert details for all 3 parameters of child class added to our listbox]);
            products.Add(new Merchandise([insert details for all 3 parameters of child class added to our listbox]);
            products.Add(new HotDrink([insert details for all 3 parameters of child class added to our listbox]);
            }

            


            */


            // Drink.cs (File)
            /*
             abstract class Drink : Product


            */

            // BakedGood.cs (File)
            /*
             
            */

            // Merchandise.cs (File)
            /*
             
            */

            // ColdDrink.cs (File)
            /*
             class ColdDrink : Drink
            // This child class ColdDrink has a base parent Drink class, and that parent class Drink class is also a child to our original base parent Product class
            {
            public ColdDrink(//dataType + objectName for each detail that our ColdDrink instance will contain.)
            // This code containing the details ^ of our ColdDrink instances
            //is an example of poly morphism.

            }
            */

            /*
             


             
            The App Goal Is To Create:

            Abstract





            Questions:

            How do you create an abstract class?
            Answer:
            To declare a class abstract, you place
            the word abstract before class, similar to static.

            Can you create a new instance of an abstract class?
            Answer:
            No. Abstract classes cannot have instances, but they can be subclassed.
            This is because an abstract class is meant to be the foundation for a class
            but not used itself.
            
            Can you give a body to an abstract method?
            Answer:
            No. A method that is declared abstract,
            has no “body” and is declared inside the abstract class only.
            The derived children HAS to create its behavior. An example of
            using the Abstract class in our Drinks Menu App is in the Product
            class where it is used to create a generic initial base parent class that
            others can inherit from, but you can make an instance of directly


            */
        }
    }
}
