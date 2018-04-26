#addin "nuget:?package=Cake.Baker"
#load "nuget:?package=Cake.Baker"

Baker.Recipe.Configure(context: Context
                       ,buildSystem: BuildSystem
                       ,title: "ReSharper.Settings"
                       ,sourceDirectoryPath: "Source"
                       ,nuspecFilePath: ".\Source\ReSharperSettings.nuspec"
                       ,artifactsPath: ".\Build\Artifacts"
                       );

Baker.MakeNuGetPackage();

