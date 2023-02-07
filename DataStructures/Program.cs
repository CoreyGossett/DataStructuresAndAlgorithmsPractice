//Arrays
//Array Insertions & Deletions

//Insertion at the end of the array O(1)

int[] intArray = new int[6];

//Make a variable to keep length because .length is based off capacity and does not track the actual index
int length = 0;

//This addes data for us
for (int i = 0; i < 3; i++)
{
    //+1 is optional, just makes it to where the first number stored is 1 instead of 0
    intArray[length] = i + 1;
    length++;
}

intArray[length] = 8;
length++;


