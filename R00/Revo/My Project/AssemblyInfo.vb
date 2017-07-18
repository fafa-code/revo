﻿Imports System.Resources

Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.IO

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.

<Assembly: AssemblyTitle("REVO")> 
<Assembly: AssemblyDescription("plugin Autocad")> 
<Assembly: AssemblyCompany("platform5")> 
<Assembly: AssemblyProduct("revo")> 
<Assembly: AssemblyCopyright("GNU GENERAL PUBLIC LICENSE")> 
<Assembly: AssemblyTrademark("platform5")>

'   >>>        <<<<
' !!  ATTENTION NE PAS OUBLIER DE MODIFIER DANS :                   <<<<<<<<<<<<<------------ !!!!!
'         ---   MyCommands.vb   LA CONSTANTE NomCMD
'         ---   urlUpdate


' Version information for an assembly consists of the following four values:
'    Major  .  Minor  . Build Number .  Revision
' <Assembly: AssemblyVersion>     <<<<------- C'est la variable de référence
<Assembly: AssemblyVersion("3.6.0.0")>
<Assembly: AssemblyFileVersion("3.6.0.0")>

' In order to sign your assembly you must specify a key to use. Refer to the 
' Microsoft .NET Framework documentation for more information on assembly signing.
'
' Use the attributes below to control which key is used for signing. 
'
' Notes: 
'   (*) If no key is specified, the assembly is not signed.
'   (*) KeyName refers to a key that has been installed in the Crypto Service
'       Provider (CSP) on your machine. KeyFile refers to a file which contains
'       a key.
'   (*) If the KeyFile and the KeyName values are both specified, the 
'       following processing occurs:
'       (1) If the KeyName can be found in the CSP, that key is used.
'       (2) If the KeyName does not exist and the KeyFile does exist, the key 
'           in the KeyFile is installed into the CSP and used.
'   (*) In order to create a KeyFile, you can use the sn.exe (Strong Name) utility.
'       When specifying the KeyFile, the location of the KeyFile should be
'       relative to the project output directory which is
'       %Project Directory%\obj\<configuration>. For example, if your KeyFile is
'       located in the project directory, you would specify the AssemblyKeyFile 
'       attribute as [assembly: AssemblyKeyFile("..\\..\\mykey.snk")]
'   (*) Delay Signing is an advanced option - see the Microsoft .NET Framework
'       documentation for more information on this.
<Assembly: AssemblyDelaySign(False)> 
<Assembly: AssemblyKeyFile("")> 
<Assembly: AssemblyKeyName("")> 

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)> 

' The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("fb0a2132-5ca7-4830-8773-03bfb36e65d9")> 

