﻿/*
 * 
 * A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

*/

using System;

class EmployeeData

{
    static void Main()
    {
        string firstName;
        string lastName;
        uint age;
        bool isMale;
        string personalIdNumber;
        int employeeNumber;
        firstName = "Orlin";
        lastName = "Draganov";
        age = 30;
        isMale = true;
        personalIdNumber = "8507256240";
        employeeNumber = 27523699;
    }
}
