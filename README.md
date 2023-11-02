# RunPE Crypter SRC

## Full Source Code:


![image](https://github.com/M6YR/RunPE-Crypter-SRC/assets/117858901/e86d8dda-22fa-44ef-b52c-9ed5ff60e3da)

- RunPE Code

![image](https://github.com/M6YR/RunPE-Crypter-SRC/assets/117858901/d7555c67-06b4-4cf6-ba98-135ae0b172e9)

----------------------------------------------------------------------

- Notes:  
  
With RunPE, Admin privileges are not possible, same with adding to startup because it will just add what it injected to startup. (Not your payload itself)  
Stub is in C# .net, the victim will inject into itself, so the victim cannot be in native, only .net.  
however if the payload is native then it can be injected into a native process like vbc.exe or cvtres.exe  
If you run into an error while compiling, try downloading/enabling the .NET 3.5 Framework/Runtime, it should solve the error. If not, open an issue.  
    
  With custom inject you need to add the name of an executable within the .NET folder, here's a list of executables:  
  AppLaunch.exe  
  aspnet_compiler.exe  
  aspnet_regbrowsers.exe  
  aspnet_regiis.exe  
  aspnet_regsql.exe  
  aspnet_state.exe  
  aspnet_wp.exe  
  CasPol.exe  
  csc.exe  
  cvtres.exe  
  dfsvc.exe  
  dw20.exe  
  IEExec.exe  
  ilasm.exe  
  InstallUtil.exe  
  jsc.exe  
  MSBuild.exe  
  mscorsvw.exe  
  ngen.exe  
  RegAsm.exe  
  RegSvcs.exe  
  vbc.exe  
