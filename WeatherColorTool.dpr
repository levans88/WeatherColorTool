program WeatherColorTool;

{$APPTYPE CONSOLE}

{$R *.res}

uses
  System.SysUtils,
  xEditAPI in 'xEditAPI.pas',
  WeatherColorTool in 'WeatherColorTool.pas';

begin
  try
    { TODO -oUser -cConsole Main : Insert code here }
  except
    on E: Exception do
      Writeln(E.ClassName, ': ', E.Message);
  end;
end.
