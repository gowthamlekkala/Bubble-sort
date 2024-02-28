/* Author: Gowtham Lekkala
 date : 28/02/2024
This code is for Bubble sort numbers*/

int[] bubble_sort_numbers = { 5,72,3,14,7,1 };


Console.WriteLine("Here is the original array that will be used to execute the Bubble Sort Algorithm: ");
for (int i = 0; i < bubble_sort_numbers.Length; i++)
{
    Console.Write("  " + bubble_sort_numbers[i]);
}

Console.WriteLine("");
Console.WriteLine("Here is the array after the execution of the Bubble Sort Algorithm: ");
Bubble_Sort(bubble_sort_numbers);
for (int i = 0; i < bubble_sort_numbers.Length; i++)
{
    Console.Write("  " + bubble_sort_numbers[i]);
}
Console.WriteLine("");
Console.WriteLine("Press any key to exit the program ...");
Console.ReadKey(true);


/*
Since there are two nested loops included in this algrorithm, we would
describe its time complexity (or Big O notation) as O(n^2). The advantage it
has over the Bubble Sort is that it never makes more than O(n) swaps. 
So, less data is required to write to memory during the swap process.
*/


// This method executes the Bubble Sort Algorithm with a worst case of time complexity (Big O Notation) of O(n^2)
static void Bubble_Sort(int[] bs_arr)
{
    // The for loop will continue until the array is sorted in ascending order.
    // Bubble Sort starts from the beginning of the array each for loop iteration and checks the value
    // of the next element in the array to see if it is less. If it is less, then swap.
    for (int i = 0; i < bs_arr.Length - 1; i++)
    {
        for (int x = 0; x < bs_arr.Length - i - 1; x++)
        {
            // In each nested for loop iteration check to see if the next element value is lower than the current element value
            // If the next element value is less, then conduct the swap
            if (bs_arr[x] > bs_arr[x + 1])
            {
                // Here you will swap temp and bs_arr[x]
                // The temp variable is used to temporarily hold the value of the current element so that it can be swapped
                int temp = bs_arr[x];
                bs_arr[x] = bs_arr[x + 1];
                bs_arr[x + 1] = temp;
            } // End of if
        } // End of inner for loop
    } // End of outer for loop
}