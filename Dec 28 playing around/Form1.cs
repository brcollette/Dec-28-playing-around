namespace Dec_28_playing_around
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] numbers = new int[10];
        int[] totals = new int[10]; 
        string numbersString = "";
        string totalsString = "";
        decimal sum = 0;
        decimal average = 0;

        private void btnCalculate_Click(object sender, EventArgs e)
        //{
        //    numbersString = "";
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        numbers[i] = i;
        //        numbersString += numbers[i] + " "; // the + and quotation marks serve to provide a space between each value
        //        // note also that we need to use numbers[i] above and not just numbers because using numbers alone just refers to
        //        // the array and not the actual information in the array. Coding it the way we have here is basically saying  
        //        // "give me the value that is stored at a the i-th position in the array 
        //    }            
        //    MessageBox.Show(numbersString, "Numbers Test");
        //}

        {
            totalsString = "";
            for (int i = 0; i < totals.Length; i++)
            {
                totals[i] = i;
                sum += totals[i];
                
                totalsString += totals[i] + "\n"; // the + and quotation marks serve to provide a space between each value
                // note also that we need to use numbers[i] above and not just numbers because using numbers alone just refers to
                // the array and not the actual information in the array. Coding it the way we have here is basically saying  
                // "give me the value that is stored at a the i-th position in the array 
                average = sum / totals.Length;
            }
            MessageBox.Show
            (
                "The totals are: \n" +
                totalsString + "\n"  +
                "Average: " + average + "\n" +
                "Sum: " + sum
                
            );
        }


    }
}
