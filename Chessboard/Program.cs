// See https://aka.ms/new-console-template for more information

int horizontal;
int vertical;
string solidLine;
string lineWithFields;
Boolean black = true;

// Ask number of horizontal blocks (columns)
Console.WriteLine("Chessboard");
Console.Write("Enter number of horizontal blocks: ");
try
{
    horizontal = Convert.ToInt32(Console.ReadLine());
}
catch (Exception e)
{
    Console.WriteLine("Illegal number. Default (8) taken: " + e.Message);
    horizontal = 8;
}


// Ask number of vertical blocks (rows)
Console.Write("Enter number of vertical blocks: ");
try
{
    vertical= Convert.ToInt32(Console.ReadLine());
}
catch (Exception e)
{
    Console.WriteLine("Illegal number. Default (8) taken: " + e.Message);
    vertical = 8;
}

Console.Write("Horizontal="+ Convert.ToString(horizontal));
Console.WriteLine(" Vertical=" + Convert.ToString(vertical));

// construxct solid horizontal line and display
solidLine = "+";
for(int i = 0; i < horizontal; i++)
{
    solidLine+="-+";
}
Console.WriteLine(solidLine);

for (int j = 0; j < vertical;j++)
{
    black = (j % 2 == 0);
    // construct number of fields
    lineWithFields = "|";
    for (int i = 0; i < horizontal; i++)
    {
        lineWithFields += (black) ? "b" : "w";
        lineWithFields += "|";
        black = !black;
    }
    Console.WriteLine(lineWithFields);
    Console.WriteLine(solidLine);
}

