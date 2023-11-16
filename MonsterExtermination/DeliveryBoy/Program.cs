/*
5 6
*----A
*B***-
*-***-
*----P
******
down
down
right
right
right
right
up
up
up

5 6
*----A
*B***-
*-***-
*----P
******
down
down
left
right
right
right
right
right
up

*/

int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int rows = dimensions[0];
int columns = dimensions[1];
char[,] neighbourhood = new char[rows, columns];
int deliveryBoyRow = 0;
int deliveryBoyCol = 0;

int startingRow = 0;
int startingCol = 0;

int pizzeriaRow = 0;
int pizzeriaCol = 0;

for (int row = 0; row < rows; row++)
{
    string currentRow = Console.ReadLine();
    for (int col = 0; col < columns; col++)
    {
        neighbourhood[row, col] = currentRow[col];
        if (neighbourhood[row, col] == 'B')
        {
            deliveryBoyRow = row;
            deliveryBoyCol = col;
            startingRow = row;
            startingCol = col;
            neighbourhood[deliveryBoyRow, deliveryBoyCol] = '-';
        }
        if (neighbourhood[row, col] == 'A')
        {
            break;
        }
    }
}
while (neighbourhood[deliveryBoyRow, deliveryBoyCol] != 'A')
{
    string command = Console.ReadLine();
    if (command == "up")
    {
        if (deliveryBoyRow == 0)
        {
            Console.WriteLine("The delivery is late. Order is canceled.");
            neighbourhood[startingRow, startingCol] = ' ';
            break;
        }
        if (neighbourhood[deliveryBoyRow - 1, deliveryBoyCol] == '*')
        {
            continue;
        }
        neighbourhood[deliveryBoyRow, deliveryBoyCol] = '.';
        deliveryBoyRow--;
    }
    else if (command == "down")
    {
        if (deliveryBoyRow == rows - 1)
        {
            Console.WriteLine("The delivery is late. Order is canceled.");
            neighbourhood[startingRow, startingCol] = ' ';
            break;
        }
        if (neighbourhood[deliveryBoyRow + 1, deliveryBoyCol] == '*')
        {
            continue;
        }
        neighbourhood[deliveryBoyRow, deliveryBoyCol] = '.';
        deliveryBoyRow++;
    }
    else if (command == "left")
    {
        if (deliveryBoyCol == 0)
        {
            Console.WriteLine("The delivery is late. Order is canceled.");
            neighbourhood[startingRow, startingCol] = ' ';

            break;
        }
        if (neighbourhood[deliveryBoyRow, deliveryBoyCol - 1] == '*')
        {
            continue;
        }
        neighbourhood[deliveryBoyRow, deliveryBoyCol] = '.';
        deliveryBoyCol--;
    }
    else if (command == "right")
    {
        if (deliveryBoyCol == columns - 1)
        {
            Console.WriteLine("The delivery is late. Order is canceled.");
            neighbourhood[startingRow, startingCol] = ' ';
            break;
        }
        if (neighbourhood[deliveryBoyRow, deliveryBoyCol + 1] == '*')
        {
            continue;
        }
        neighbourhood[deliveryBoyRow, deliveryBoyCol] = '.';
        deliveryBoyCol++;

    }

    if (neighbourhood[deliveryBoyRow, deliveryBoyCol] == 'P')
    {
        pizzeriaRow = deliveryBoyRow;
        pizzeriaCol = deliveryBoyCol;
        neighbourhood[deliveryBoyRow, deliveryBoyCol] = 'R';
        Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
    }
    if (neighbourhood[deliveryBoyRow, deliveryBoyCol] == 'A')
    {
        Console.WriteLine("Pizza is delivered on time! Next order...");
        neighbourhood[startingRow, startingCol] = 'B';
        break;
    }

}
neighbourhood[deliveryBoyRow, deliveryBoyCol] = 'P';
neighbourhood[pizzeriaRow, pizzeriaCol] = 'R';


for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < columns; col++)
    {
        Console.Write(neighbourhood[row, col]);
    }
    Console.WriteLine();
}






int[] dimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

string[,] field = new string[dimentions[0], dimentions[1]];

int boyRow = -1;
int boyCol = -1;

int startRow = -1;
int startCol = -1;

bool hasLeft = false;

for (int i = 0; i < field.GetLength(0); i++)
{
    string newRow = Console.ReadLine();
    for (int j = 0; j < field.GetLength(1); j++)
    {
        field[i, j] = newRow[j].ToString();

        if (field[i, j] == "B")
        {
            boyRow = i;
            boyCol = j;
            startRow = i;
            startCol = j;
        }
    }
}


while (true)
{
    string command = Console.ReadLine();

    if (command == "left")
    {
        if (boyCol > 0)
        {
            if (field[boyRow, boyCol - 1] == "*")
            {
                continue;
            }

            if (field[boyRow, boyCol] != "R")
            {
                field[boyRow, boyCol] = ".";
            }
            boyCol--;
        }
        else
        {
            if (field[boyRow, boyCol] == "-")
            {
                field[boyRow, boyCol] = ".";
            }
            hasLeft = true;
            Console.WriteLine("The delivery is late. Order is canceled.");
            break;
        }
    }

    if (command == "right")
    {
        if (boyCol < field.GetLength(1) - 1)
        {
            if (field[boyRow, boyCol + 1] == "*")
            {
                continue;
            }
            if (field[boyRow, boyCol] != "R")
            {
                field[boyRow, boyCol] = ".";
            }
            boyCol++;
        }
        else
        {
            if (field[boyRow, boyCol] == "-")
            {
                field[boyRow, boyCol] = ".";
            }
            hasLeft = true;
            Console.WriteLine("The delivery is late. Order is canceled.");
            break;
        }
    }

    if (command == "up")
    {
        if (boyRow > 0)
        {
            if (field[boyRow - 1, boyCol] == "*")
            {
                continue;
            }
            if (field[boyRow, boyCol] != "R")
            {
                field[boyRow, boyCol] = ".";
            }
            boyRow--;
        }
        else
        {
            if (field[boyRow, boyCol] == "-")
            {
                field[boyRow, boyCol] = ".";
            }
            hasLeft = true;
            Console.WriteLine("The delivery is late. Order is canceled.");
            break;
        }
    }

    if (command == "down")
    {
        if (boyRow < field.GetLength(0) - 1)
        {
            if (field[boyRow + 1, boyCol] == "*")
            {
                continue;
            }
            if (field[boyRow, boyCol] != "R")
            {
                field[boyRow, boyCol] = ".";
            }
            boyRow++;
        }
        else
        {
            if (field[boyRow, boyCol] == "-")
            {
                field[boyRow, boyCol] = ".";
            }
            hasLeft = true;
            Console.WriteLine("The delivery is late. Order is canceled.");
            break;
        }
    }

    if (field[boyRow, boyCol] == "P")
    {
        Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
        field[boyRow, boyCol] = "R";
        continue;
    }

    if (field[boyRow, boyCol] == "A")
    {
        field[boyRow, boyCol] = "P";
        Console.WriteLine("Pizza is delivered on time! Next order...");
        break;
    }
}

if (hasLeft)
{
    field[startRow, startCol] = " ";
}
else
{
    field[startRow, startCol] = "B";
}

for (int i = 0; i < field.GetLength(0); i++)
{
    for (int j = 0; j < field.GetLength(1); j++)
    {
        Console.Write(field[i, j]);
    }
    Console.WriteLine();
}