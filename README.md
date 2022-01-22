# Luma
An editor in C# to edit BMG files from Super Mario Galaxy

## Features
  - Reads and edits message files from Super Mario Galaxy
  - Allows to add entries
  - Has a GUI

## What it doesn't do (at least for now)
  - It can't read (for now) files from the SM3D All Stars version (WIP)
  - Events (or whatever they are called) aren't supported at the moment (I'm missing documentation for the FLW1 section and haven't took time to dive into that yet)
  - Editing message files from Super Mario Galaxy **_2_**
  
## Issues
  If you notice a bug or if you think something's missing, please open an issue
  - Escape sequences could be displayed in a better way (i.e. as XML instead of `*size+binvalue`)
  - YAZ0 decoding doesn't work for little endian (that's why I have some issues supporting SM3DAS)
  - Some BMG code should be refactored and some portions entirely rewritten
  
### Other
  - DON'T fork the repository. Contributions here are welcome, encouraged and recommended.
  - BMG documentation is available here [BMG documentaion page](https://bussun.github.io/docs/bmg.html) (I'll finish writing all I know asap)

## Building the software
  Download and open the solution in Visual Studio Community. It should build without any issue
  
## Credits and license
  You can find the license in LICENSE.md (It's short don't worry)

  Credits:
  - The old C# version of Whitehole for RARC, BCSV and big endian code
  - YAZ0 decoding code inspired by EveryFileExplorer
  - Please tell me if I forgot something, I'll add it asap
