This folder consist of the necessary functionality to run the program as a console command-line application for testing purposes. In addition to the necessary code to run the chatbot program in a command-line environment, it consist of functionality to conduct automated testing, contained in the TestFramework and PatternTest folders, respectively.

The TestFramework folder consist of the definition of the class 'PatternTest' containing the functionality to test patterns of the Eliza chatbot, and also the parent class of 'PatternTest' which is 'Test'. 

The PatternTests folder consists of specific tests for all Complex and FormatFree patterns implemented for this version of the chatbot program. These patterns can be found in the Eliza folder. Each test for complex for format-free patterns is an instance of the 'PatternTest' class,  and each derives from the parent class 'Test'.   

This folder is otherwise similar to the Eliza_main folder, and thus the following information also applies to that folder:
=============
Note that the Eliza class is separate from this (it is located in the Eliza folder), and can be used if its functionality were to be employed, for instance, in an android or windoes GUI application. 

the ConsoleLogger class implements the ILogger interface (present in the Eliza folder), and consists of the methods necessary to perform logging operations for a console application.

Furthermore, this folder contains the Program class, which consist of the Main method that runs the console application. 
