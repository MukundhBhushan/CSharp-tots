- assembly is a pre-compiled code

- types based on extension
    - exe
    - dll

- exe: 
    - it is a self executable file which has the extension ".exe"
- dll: 
    - stands for dynamic link library. 
    - It has the extension ".dll". 
    - It requires another program or application to get executed

- types of assemblies
    - private assembly: is part of your application. It is stored under your application root folder. 
    - public or shared assembly: Available for multiple applications. It is stored in the GAC(Global assembly cache). GAC is present in "C:/windows/assembly" folder.
    - satllite: This is used to store non assembly related files. Eg: Images, Icons, files such as PDF, Excels.

- Reflection: 
    - To get assembly information at run time ie meta data.
    - using System.Reflection namespace is required to asscess it
    - assembly information contains:
        - version including major and minor
        - type of application
        - size 
        - 