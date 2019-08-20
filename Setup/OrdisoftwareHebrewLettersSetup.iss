; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Hebrew Letters"
#define MyAppNameNoSpace "HebrewLetters"
#define MyAppVersion "2.0"
#define MyAppPublisher "Ordisoftware"
#define MyAppURL "http://www.ordisoftware.com/projects/hebrew-letters"
#define MyAppExeName "Ordisoftware.HebrewLetters.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{1FD1454B-F437-4AC5-844F-C3649D664D8F}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppPublisher} {#MyAppName} {#MyAppVersion}
AppCopyright=Copyright 2019 Olivier Rogier
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
UninstallFilesDir={app}\Uninstall
DefaultDirName={pf}\{#MyAppPublisher}\{#MyAppName}
DefaultGroupName={#MyAppPublisher}
AllowNoIcons=true
LicenseFile=..\Project\License\MPL 2.0.rtf
InfoBeforeFile=
OutputDir=.\
OutputBaseFilename={#MyAppPublisher}{#MyAppNameNoSpace}Setup-{#MyAppVersion}
SetupIconFile=
Compression=lzma
SolidCompression=true
ChangesAssociations=true
ShowTasksTreeLines=true
VersionInfoVersion={#MyAppVersion}
VersionInfoCompany={#MyAppPublisher}
VersionInfoDescription={#MyAppPublisher} {#MyAppName}
PrivilegesRequired=admin
InternalCompressLevel=normal
ArchitecturesAllowed=x86 x64 ia64
ArchitecturesInstallIn64BitMode=x64 ia64
DisableStartupPrompt=false

[Languages]
Name: english; MessagesFile: compiler:Default.isl
Name: french; MessagesFile: compiler:Languages\French.isl

[CustomMessages]
english.RunSettings_msg=Modify application settings
french.RunSettings_msg=Modifier les param�tres de l'application
english.DotNetRequired_msg=Install .NET Framework 3.5
french.DotNetRequired_msg=Installer .NET Framework 3.5
english.DotNetInstalling_msg=Microsoft Framework 3.5 is being installed. Please wait...
french.DotNetInstalling_msg=Microsoft Framework 3.5 est en cours d'installation. Veuillez patienter...
english.HelpFile_msg=Documentation of %1
french.HelpFile_msg=Documentation de %1
english.LicenseFile_msg=License of %1
french.LicenseFile_msg=Licence de %1
english.SourceCode_msg=Source code of %1
french.SourceCode_msg=Code source de %1
english.StartWithWindows_msg=Start with Windows
french.StartWithWindows_msg=D�marrer avec Windows

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}
Name: quicklaunchicon; Description: {cm:CreateQuickLaunchIcon}; GroupDescription: {cm:AdditionalIcons}

[Dirs]

[Files]
; NOTE: Don't use "Flags: ignoreversion" on any shared system files
Source: ..\Bin\Release\*.exe; DestDir: {app}\Bin; Flags: ignoreversion recursesubdirs; Excludes: *vshost.exe
Source: ..\Bin\Release\*.dll; DestDir: {app}\Bin; Flags: ignoreversion recursesubdirs skipifsourcedoesntexist
Source: ..\Bin\Release\*.pdb; DestDir: {app}\Bin; Flags: ignoreversion recursesubdirs skipifsourcedoesntexist
Source: ..\Bin\Release\*.xml; DestDir: {app}\Bin; Flags: ignoreversion recursesubdirs skipifsourcedoesntexist
Source: ..\Help\*; DestDir: {app}\Help; Flags: ignoreversion recursesubdirs skipifsourcedoesntexist
Source: ..\Project\License\*; DestDir: {app}\Project\License; Flags: ignoreversion recursesubdirs
Source: ..\Project\Dependencies\*; DestDir: {app}\Project\Dependencies\; Flags: ignoreversion recursesubdirs skipifsourcedoesntexist
Source: ..\Project\Properties\*; DestDir: {app}\Project\Properties\; Flags: ignoreversion recursesubdirs
Source: ..\Project\Source\*; DestDir: {app}\Project\Source\; Flags: ignoreversion recursesubdirs; Excludes: *.lnk
Source: ..\Project\*; DestDir: {app}\Project; Flags: ignoreversion; Excludes: *.suo, *.user
Source: ..\Project\Data\Alphabet.txt; DestDir: {app}\Project\Data; Flags: ignoreversion; Excludes: *.suo, *.user
Source: ..\Register ODBC.reg; DestDir: {app}
Source: ..\*; DestDir: {app}; Flags: ignoreversion
Source: *; DestDir: {app}\Setup; Excludes: *.---, {#MyAppPublisher}{#MyAppNameNoSpace}Setup*.exe
Source: ..\Project\Dependencies\Font\Hebrew.ttf; DestDir: {fonts}; FontInstall: Hebrew Normal; Flags: onlyifdoesntexist uninsneveruninstall

[Icons]
Name: {commondesktop}\{#MyAppPublisher} {#MyAppName}; Filename: {app}\Bin\{#MyAppExeName}; Tasks: desktopicon; IconFilename: {app}\Application.ico
Name: {app}\{cm:LaunchProgram,{#MyAppName}}; Filename: {app}\Bin\{#MyAppExeName}; IconFilename: {app}\Application.ico
Name: {group}\{cm:LaunchProgram,{#MyAppName}}; Filename: {app}\Bin\{#MyAppExeName}; IconFilename: {app}\Application.ico
Name: {group}\{cm:ProgramOnTheWeb,{#MyAppPublisher}}; Filename: {app}\Ordisoftware.com.url; IconFilename: {app}\Project\Dependencies\Fatcow\house.ico
Name: {group}\{#MyAppName}\{cm:SourceCode_msg,{#MyAppName}}; Filename: {app}\Project; IconFilename: {app}\Project\Dependencies\Fatcow\page_white_csharp.ico; WorkingDir: {app}\Project
Name: {group}\{#MyAppName}\{cm:HelpFile_msg,{#MyAppName}}; Filename: {app}\Help\index.htm; IconFilename: {app}\Project\Dependencies\Fatcow\help.ico
Name: {group}\{#MyAppName}\{cm:LicenseFile_msg,{#MyAppName}}; Filename: {app}\Project\License\MPL 2.0.htm; IconFilename: {app}\Project\Dependencies\Fatcow\info_rhombus.ico
Name: {group}\{#MyAppName}\{cm:ProgramOnTheWeb,{#MyAppName}}; Filename: {app}\Hebrew Letters.url; IconFilename: {app}\Project\Dependencies\Fatcow\house.ico
Name: {group}\{#MyAppName}\{cm:UninstallProgram,{#MyAppName}}; Filename: {uninstallexe}

[Run]
;Parameters: /passive /norestart;
Filename: {app}\Setup\dotnetfx35setup.exe; Check: CheckForFramework; StatusMsg: {cm:DotNetInstalling_msg}
Filename: {app}\Bin\{#MyAppExeName}; Description: {cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}; Flags: nowait postinstall skipifsilent unchecked
Filename: c:\Windows\regedit.exe; Parameters: "/s ""{app}\Register ODBC.reg"""

[Code]
function IsDotNetDetected(version: string; service: cardinal): boolean;
// Indicates whether the specified version and service pack of the .NET Framework is installed.
//
// version -- Specify one of these strings for the required .NET Framework version:
//    'v1.1.4322'     .NET Framework 1.1
//    'v2.0.50727'    .NET Framework 2.0
//    'v3.0'          .NET Framework 3.0
//    'v3.5'          .NET Framework 3.5
//    'v4\Client'     .NET Framework 4.0 Client Profile
//    'v4\Full'       .NET Framework 4.0 Full Installation
//    'v4.5'          .NET Framework 4.5
//
// service -- Specify any non-negative integer for the required service pack level:
//    0               No service packs required
//    1, 2, etc.      Service pack 1, 2, etc. required
var
    key: string;
    install, release, serviceCount: cardinal;
    check45, success: boolean;
var reqNetVer : string;
begin
    // .NET 4.5 installs as update to .NET 4.0 Full
    if version = 'v4.5' then begin
        version := 'v4\Full';
        check45 := true;
    end else
        check45 := false;

    // installation key group for all .NET versions
    key := 'SOFTWARE\Microsoft\NET Framework Setup\NDP\' + version;

    // .NET 3.0 uses value InstallSuccess in subkey Setup
    if Pos('v3.0', version) = 1 then begin
        success := RegQueryDWordValue(HKLM, key + '\Setup', 'InstallSuccess', install);
    end else begin
        success := RegQueryDWordValue(HKLM, key, 'Install', install);
    end;

    // .NET 4.0/4.5 uses value Servicing instead of SP
    if Pos('v4', version) = 1 then begin
        success := success and RegQueryDWordValue(HKLM, key, 'Servicing', serviceCount);
    end else begin
        success := success and RegQueryDWordValue(HKLM, key, 'SP', serviceCount);
    end;

    // .NET 4.5 uses additional value Release
    if check45 then begin
        success := success and RegQueryDWordValue(HKLM, key, 'Release', release);
        success := success and (release >= 378389);
    end;

    result := success and (install = 1) and (serviceCount >= service);
end;

function CheckForFramework(): Boolean;
begin
    result := not IsDotNetDetected('v3.5', 0);
end;

function UpdateReadyMemo(Space, NewLine, MemoUserInfoInfo, MemoDirInfo, MemoTypeInfo, MemoComponentsInfo, MemoGroupInfo, MemoTasksInfo: String): String;
var
	s: string;
begin
	s := MemoDirInfo;
  if ( MemoGroupInfo <> '' ) then
		s := s + NewLine + NewLine + MemoGroupInfo;
  if ( MemoTasksInfo <> '' ) then
		s := s + NewLine + NewLine + MemoTasksInfo;
  if ( CheckForFramework() ) then
  begin
		s := s + NewLine + NewLine + ExpandConstant('{cm:DotNetRequired_msg}');
  end;
	Result := s
end;
