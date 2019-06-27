errors: 
- compile time 
- run time
try: executes always. To be used in the code block which might fail
catch: executes wehn error occurs. More than 1 catch can be written
finally: for code clean up

Specific exception(DivideByZeroException,FileNotFoundException) should always be before generic expreption(Exception)

If the error occurs in the catch block itself
use try-catch in it 
