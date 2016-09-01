
/* Name: Raúl González Cruz
 * ID: 151211
 * Date: 10/09/2015
 * Name of the environment: Visual Studio
 * Language: C#
 * References:  https://msdn.microsoft.com/es-es/library/b873y76a(v=vs.110).aspx
 *              Dr. Juan Carlos Galán Hernández
 *              Mtarial showed in the course "Data Structures" on Blackboard
 *              http://ortizol.blogspot.mx/2013/09/arreglos-en-c.html
 *              https://msdn.microsoft.com/es-es/library/aa288453(v=vs.71).aspx
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Graphic_User_Interface
{
    public partial class Interface : Form

    {
        TheArray Array;
        int found;
        int size2;
        bool vacio;

        //Constructor of the class Interface
        public Interface()
        {
            InitializeComponent();
            size2 = 10;
            Array = new TheArray(size2);
            vacio = true; //I decided that the program can show a message when the array is empty and it hasn´t been used
        }

        /*When it´s chosen this option, the user can see the objects, which them he/she can introduce a number. 
         For this submenu, it functions with boolean arguments of the objects, and it produce
         the visualization of the objects*/
        private void addOneElementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //I decided to hide the richTextBox when the user want to add an element
            if (showContentsToolStripMenuItem.Checked == true)
            {
                showContentsToolStripMenuItem.Checked = false;
                richArea.Visible = false;
            }
            /*The program makes visible the objects that can add or cancel.
             * */
            textBox1.Visible = true;
            bAdd.Visible = true;
            bCancel.Visible = true;
        }

        /*This button is shown when the user pick up the submenu "Add one element". 
         * Then, this button calls a method that adds a number
         * */
        private void bAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                //If the text introduced is not a number, go to catch
                int element = Convert.ToInt32(textBox1.Text);
                Array.add(element); //Call the method "add" of the object Array
                //The process ends and the program "clear" the interface. Clear means that the interface is "alone" 
                textBox1.Clear();
                textBox1.Visible = false;
                bAdd.Visible = false;
                vacio = false; //The array has lost his "ability": empty
                bCancel.Visible = false;
            }
            catch
            { //The program shows an error message.
                MessageBox.Show("Write an integer number, please", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                textBox1.Clear(); //With this, the user can introduce another number and doesn´t have to select again the submenu "Add one element"
            }
        }

        /*The program adds what is contained in a text file in our array
         */
        private void addFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //I decided to hide the richTextBox when the user want to add from file
            if (showContentsToolStripMenuItem.Checked == true)
            {
                showContentsToolStripMenuItem.Checked = false;
                richArea.Visible = false;
            }
            Array.add_from(); //Call the method "add_from" of the object Array
            vacio = false; //The program has lost his "ability": empty
        }

        /*When it´s chosen this option, the program shows the objects with them the user can delete an element.
         * Again, I decided to hide the richTextBox if it is visible
         */
        private void deleteOneElementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showContentsToolStripMenuItem.Checked == true)
            {
                showContentsToolStripMenuItem.Checked = false;
                richArea.Visible = false;
            }
            textBox1.Visible = true;
            bCancel.Visible = true;
            bDelete.Visible = true;
            
        }

        /*When it´s chosen this option, the user can see the numbers that are contained in the array. 
         * For this, a richTextBox copy the numbers of the array.
         * The user can show or hide the richTextBox whenever he wants.
         This code works with boolean variables too*/
        private void showContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //The richTextBox is invisible if the condition is true
            if (showContentsToolStripMenuItem.Checked == false)
            {
                string cadena = ""; //Cadena is going to "copy" the elements of the array
                if (vacio == true) //The user has not added a number yet
                {
                    MessageBox.Show("The array is empty", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    cadena = Array.show(cadena); //Call the method "show" of the object Array. Cadena will be empty
                    richArea.Visible = true;
                    richArea.Text = cadena; //The richtextBox is empty
                    showContentsToolStripMenuItem.Checked = true;
                }
                else
                { //At this point, the user has introduced a number
                    cadena = Array.show(cadena); //Call the method "show" of the object Array. Cadena receives and copy the numbers
                    richArea.Visible = true;
                    richArea.Text = cadena; //The richTextBox will show numbers in one column
                    showContentsToolStripMenuItem.Checked = true;
                    richArea.SelectionStart = richArea.TextLength; //The cursor is placed at the end of our numbers
                }

            }
            else
            {   //The rich text box is visible
                //So, we want to make it invisible with the next lines of code
                richArea.Visible = false;
                showContentsToolStripMenuItem.Checked = false;
            }

        }

        /*When it´s chosen this option, the user can see the objects with them we can sort our array 
         * */
        private void sortContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] a = new int[size2]; //We create another array that helps the method "sort" of the object Array
            string cadena1 = "";
            cadena1 = Array.sort(a); //Call the method "sort" of the object Array. Then, cadena copy the content of the array "a"
            richArea.Text = cadena1; //The richTextBox copy our array sorted in one column
        }


        /*When it´s chosen this option, the user can see objects, with them someone can introduce a number and look it for. 
         * The program works with boolean variables too
         * */
        private void searchContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            bSearch.Visible = true; 
            bCancel.Visible = true;
        }

        /*When the user has picked up the option "Search contents", this button can call the action of looking for a number.
         * It works with an integer number. So, this button function as the "Add" button.
         * Finally, the program shows if the number is in the array or not.
         * */
        private void bSearch_Click(object sender, EventArgs e)
        {
            if (vacio == true)
            { //At this point, the user hasn´t introced any number in the array. So, for me, there is no reason to call the method "search"
                // I mean, is not necesary because the array is empty, there are any element
                try
                {
                    int element = Convert.ToInt32(textBox1.Text); //But I verify that the user has really introduced an integer number
                    MessageBox.Show("The number doesn´t appear in the array. Sorry :(", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    textBox1.Clear(); //The program hide the objects that call the method "search"
                    textBox1.Visible = false;
                    bSearch.Visible = false;
                    bCancel.Visible = false;
                }
                catch
                { //The user has not introduced an integer number in the textBox
                    MessageBox.Show("Write an integer number, please", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    textBox1.Clear();
                }
            }
            else
            { //The user has introduced a number in the list, so...
                try
                {  //I verify the user want to search an integer number
                    int element = Convert.ToInt32(textBox1.Text);
                    found = Array.search(element); //"Found" helps the program to know if the element was found in the array...
                    if ( found == -1) //Here, the element hasn´t been found, so the program...
                    { //Notifies the user
                        MessageBox.Show("The number " + element + " doesn´t appear in the list. Sorry :(", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    }//We "clean" the interface
                    textBox1.Clear();
                    textBox1.Visible = false;
                    bSearch.Visible = false;
                    bCancel.Visible = false;
                }
                catch
                { //The user has not introduced an integer number
                    MessageBox.Show("Write an integer number, please", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    textBox1.Clear();
                }
            }
        }

        /*When the user choose this option, the program ends immediately, so the user "exits".
         * To work, the user only needs to pick it up
         * Finally, the program finishes.
         * */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /*If the user has picked up by mistake (e.g "Add one element" or "Search contents"), this button helps to "close"
        these options. The button works with boolean variables, because it makes the text box and the buttons
         * invisible.
         * So, it produces the option "cancel" or "hide" */
        private void bCancel_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Visible = false;
            bAdd.Visible = false;
            bSearch.Visible = false;
            bCancel.Visible = false;
            bDelete.Visible = false;
        }

        /*If the user has picked the submenu "Delete one element", this button appears and call the action "delete"
        The button works with a boolean variable, because it helps the program to know if the number appears or not in the array
         * So, let´s ckeck how it functions*/
        private void bDelete_Click(object sender, EventArgs e)
        {
            try
            { //¿The user has introduced an integer number?
                int element = Convert.ToInt32(textBox1.Text);
                int aux = 1; 
                //The method "delete" needs the number and the "aux" verification
                aux = Array.delete(element, aux); //Let´s verify that the number is in the array. So, we call the method "delete" of the object Array
                if (aux == 1) //Well, the number isn´t in the array, so...
                { //Notifies the user
                    MessageBox.Show("The number " + element + " doesn´t appear in the array", "Warning", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                }
                //We "clean" the interface
                textBox1.Clear();
                textBox1.Visible = false;
                bDelete.Visible = false;
                bCancel.Visible = false;
            }
            catch
            { //The number introduced isn´t an integer
                MessageBox.Show("Write an integer number, please", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                textBox1.Clear();
            }
        }

        /*I want to be creative, so I want to change the color of my buttons when the cursor is over them
         * So, I need two methodos for each button...*/
        //MouseEnter and MouseLeave
        /*With MouseEnter, mens that the cursor is over the button, so I want to change the color...to call the atention
         *But I need to restore the original color of the button if I want to make the difference, so MouseLeave make it possible,
         *and it means that the button has it original colors because the cursor is not over it
         *Finally, I can change the colors of a button when the cursor is over it or not.
         */
        private void bCancel_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Red;
            btn.ForeColor = Color.White;
        }

        private void bCancel_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Silver;
            btn.ForeColor = Color.Black;
        }

        private void bAceptar_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Blue;
            btn.ForeColor = Color.Aqua;
        }

        private void bAceptar_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Silver;
            btn.ForeColor = Color.Black;
        }

        private void bSearch_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Purple;
            btn.ForeColor = Color.HotPink;
        }

        private void bSearch_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Silver;
            btn.ForeColor = Color.Black;
        }

        private void bDelete_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Brown;
            btn.ForeColor = Color.Gold;
        }

        private void bDelete_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Silver;
            btn.ForeColor = Color.Black;
        }

        /* And why not I change the color of the submenu exit when the cursor is over it?
         * It´s possible with the next two methods: MouseEnter and MouseLeave
         * They function as we explained for the buttons
         * */
        private void exitToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ToolStripItem ms = sender as ToolStripItem;
            ms.ForeColor = Color.White;
        }

        private void exitToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ToolStripItem ms = sender as ToolStripItem;
            ms.ForeColor = Color.Black;
        }
    }



    class TheArray
    {
        int[] data;
        int size;
        int count;
        //Constructor of my class TheArray with one argument
        public TheArray(int s) // s is going to be used for the size of my array
        {
            size = s;
            data = new int[size]; //Specifically here we use "s"
            count = 0; //We use this variable because it´s going to indicate how many elements are in the array
        }
        public void add(int element)
        { //Receives the number to add
            if (count < size) //Is there space in the array?
            { //Number stored !
                data[count] = element;
                count++; //When we add, there is less space in the array
            }
            else
            { //Mmmmmmmm... there is no space :(
                MessageBox.Show("The array is full. The number " + element + " can´t be introduced. Sorry :(", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

            }
        }
        public int delete(int element, int aux)
        { //Receives a number and a verification number
            int i = 0;
            while (i<count) //We have to start from the beginning of the array
                {
                    if (data[i] == element) //Have we found the element?
                    {
                        while(i < (count-1))
                        { //Yes! So, I decide to replace the numbers to the left
                            data[i] = data[i + 1];
                            i++;
                        }//When it finishes...
                        aux = -1; //The verification number means that we have found the element
                        count--; //The element found is in the last element of the array, so we reduce count to "eliminate" the number
                        //I mean, that we don´t consider the last element any more, and we can "eliminate" it
                        MessageBox.Show("The number " + element + " has been removed", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    }
                    i++;
                } //The verification number has to be returned
                return aux;
        }

        public void add_from()
        {
            //For this action, we need an array that can copy string elements"
            string[] array;
            //The program reads a text file. NOTE: for this code, I used an specific direction, so, 
            // when the user execute this, he has to change the route of the text file.
            using (StreamReader sr = new StreamReader("C:\\Users\\Raúl\\Desktop\\numeros.txt"))
            {
                //NOTE: The text file must contain a column of numbers. If not, this action can´t be performed
                string line = sr.ReadToEnd(); //The column of numbers is read in this form:
                /*Example:
                 9
                 6
                 12
                 23*/
                array = line.Split('\n'); //Here, we get string data and we stored it, and not "numbers"
                for (int i = 0; i < array.Length; i++)
                { //Call the method add of our class TheArray, and as we can see, we have to convert to integer our data
                    add(Convert.ToInt32(array[i]));
                } //The program has done this action
                MessageBox.Show("This operation has finished", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }

        public string show(string cadena)
        { //Receive a string where we are going to copy data
            for (int i = 0; i < count; i++)
            { //Cadena copy the numbers. We need to add "\n" to generate a column of numbers
                cadena = cadena + Convert.ToString(data[i]) + "\n";
            } //Return a column of numbers
            return cadena;
        }

        public string sort(int[] a)
        { //We need a new array for this action, because there I want to store an "integer" column of numbers
           string cadena = ""; 
           if (count == 0)
           { //The user has not introduced a number
               MessageBox.Show("The array is empty", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
           }
           else
           { //I decide to sort my array with the quicksort method, that receives the array to sort, the first and the last position
               a = quicksort(data, 0, (count - 1));
               for (int i = 0; i < count; i++)
               { //Then cadena will contain finally a column of numbers type string
                   cadena = cadena + Convert.ToString(a[i]) + "\n";
               }
           } 
           return cadena;
        }

        private int[] quicksort(int[] data, int primero, int ultimo)
        { //For this method, I need to declare:
            int i, j, central, pivote;
            central = (primero + ultimo) / 2; //Get "middle" position
            pivote = data[central]; //Get the element in the middle of the array
            i = primero; //First position
            j = ultimo; //Last position
            do
            {
                while (data[i] < pivote) i++; //The cycle end when we found a bigger number than pivote
                while (data[j] > pivote) j--; //The cycle end when we found a smaller number than pivote
                if (i <= j)
                { //Pivote in the middle, bigger number is on the left and smaller number is on the right
                    int temp;
                    //We have to change this numbers, so smaller numbers are before pivote and bigger numbers are after pivote
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++; //We need to verify all the numbers before the pivote, because it can appear another bigger number than pivote
                    j--; //We need to verify all the numbers after the pivote, because it can appear another smaller number than pivote
                }
            } while (i <= j); //We have two groups:
            /* Smaller numbers than pivote
             *                              Pivote  
             *                                      Bigger numbers than pivote
             * */

            if (primero < j)
            { //But.... we have to sort the group "Smaller numbers than pivote"
                /*We have to call noch ein mal the function quicksort to do this, so we gave the first and the last position of the group
                 * "Smaller than pivote", and the program will do the previous steps
                 * In this case pivote is not considered any more
                 * primero = first position
                 * j = last position
                 */
                quicksort(data, primero, j);
            }

            if (i < ultimo)
            {
                //But.... we have to sort also the group "Bigger numbers than pivote"
                /*We have to call noch ein mal the function quicksort to do this, so we gave the first and the last position of the group
                 * "Bigger than pivote", and the program will do the previous steps
                 *In this case pivote is not considered any more 
                 *i = first position
                 * ultimo = last position
                 */
                quicksort(data, i, ultimo);
            } 
            //Finally, we have sorted our array completely
           return data;
        }

        public int search(int element)
        {
            int result = -1; //Element not found
            for (int c = 0; c < count; c++)
            { //We have to ckeck all the elements in the array..
                if (data[c] == element) //Element found?
                { //Yes! Notifies the user indicating the number and the position in the array
                    MessageBox.Show("The number " + element + " is in the position " + (c + 1) + " in the array", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    result = 1; //Verification number shows that the elemnt was found
                }
            } //Return the verification number
            return result;

        }
    }
}