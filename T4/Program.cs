using System;

var age = new int[10];
age[0] = 12;
age[1] = 15;
age[2] = 25;
age[3] = 12;
age[4] = 56;
age[5] = 13;
age[6] = 81;
age[7] = 55;
age[8] = 25;
age[9] = 12;

int count = 1;
var dublicat = new Dictionary<int, int>();
for (int indexA = 0; indexA < 9; indexA++)
{
   
    for (int indexB = indexA+ 1;indexB < 10; indexB++)
    {
        if (age[indexA] == age[indexB])
            count++; 
        
    }
    
}


