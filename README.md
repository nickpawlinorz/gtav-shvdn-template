# GTA V SHVDN Template
This repositoy can be used as a template to get started with a GTA V Script using [Community Script Hook V .NET](https://github.com/crosire/scripthookvdotnet).
## Requirements
- Make sure that [Community Script Hook V .NET](https://github.com/crosire/scripthookvdotnet) is installed as described [here](https://github.com/crosire/scripthookvdotnet).
## Usage
Simply change the project name in these files to your desired project name:

- root directory name
- project file names
- ``.csproj`` ``RootNamespace`` Attribute

### Post Build Event

After creating a build these files will be copied to your ``scripts`` directory in the GTA V installation path. You need to change the path according to your installation path in the `.csproj` file under `GTAVDirectory` Property. This can be used to quickly reload your scripts while developing. Just use the `Reload()` function in the SHVDN console (`F4`) inside of GTA V.
You can paste all necessary data into the Output folder so it will also be transferred to your `scripts` directory after each build. In the case you want to exclude some types of files you could add them to the `postbuildmoveignore.txt` file.

If you don't want to use a post build event you need to manually remove it from the ``*.csproj`` file (`Target` attribute).