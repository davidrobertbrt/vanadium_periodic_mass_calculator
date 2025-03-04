# Vanadium chemical analysis and calculation

***This app was developed during the summer of 2019. Personal archived project.***

## Description
Vanadium is a Windows application developed in C# using WinForms that provides tools for chemical analysis and calculation. It features a periodic table, a molecular mass calculator, and a degree of unsaturation calculator. The application also includes parsers for popular chemical formulas and elements, which are stored in TXT format.

## Motivation
The development of Vanadium was driven by a personal need to simplify the process of completing chemistry homework. By creating a tool that combines an interactive periodic table, a molecular mass calculator, and a degree of unsaturation calculator, I aimed to make my own study sessions more efficient and productive. This app has helped me complete assignments faster and with greater accuracy, and I hope it can do the same for other students and chemistry enthusiasts.

## Features

### Periodic table
- Interactive periodic table with detailed information about each element.
- Custom WinForms controls to enhance user experience.

### Molecular mass calculator
- Calculates the molecular mass of chemical formulas with a custom parser.
- Includes the most popular chemical formulas used in problem solving

### Degree of unsaturation calculator
- Computes the degree of unsaturation for given chemical formulas.
- Supports various elements and their common valences.

### Tab system
- Includes a tab system custom written in WinForms.
- To close a tab right click a icon in the top left side of the app.
- To add one click on the + button. A dropdown will show the available tabs.

### Clipboard system
- A button with the icon of clipboard will copy the result.

### Preview elements
- A custom made engine to draw electrons of the elements and show important information about each one.

## Screenshots

### Periodic table
![image](https://github.com/user-attachments/assets/46f5affe-fcb2-4fe5-b3d7-076490a78a17)
![image](https://github.com/user-attachments/assets/056079b4-5dae-492e-b50f-65751d08a8fc)

### Molecular mass calculator
![image](https://github.com/user-attachments/assets/990408fa-29de-41a3-bb95-718dd21046f3)

### Unsaturation calculator
![image](https://github.com/user-attachments/assets/496701ab-93cd-4bf4-94f5-c39545e4566d)

### Search system for elements
![image](https://github.com/user-attachments/assets/0322e0a6-ad82-4bf0-ad1a-830b62933961)

## How to use the app

### Prerequisites
- Windows operating system (at least Windows 7)
- .NET Framework installed (version 4.6.1)

### Installation
1. Clone this repo:
```bash
git clone https://github.com/davidrobertbrt/vanadium_periodic_mass_calculator.git
```

2. Open the solution file in Visual Studio.
3. Build the solution to restore the necessary packages.
4. Run the application

## Usage
1. Periodic Table:
   - Navigate through the elements to view their properties.
   - Use the search functionality to find specific elements quickly.
   - To see the electron structure click on the element and a preview will open in another window.

2. Molecular Mass Calculator:
    - Enter a chemical formula to calculate its molecular mass.
    - The calculator already has a wide range of common chemical formulas. Any formula can be computed.
    - Formula structure in text is: 
```
H2O for example computes the molecular mass of water. The app supports an infinite amount of chemical elements. Also the number of atoms can be as big as you want. The app computes for the next element if the number of atoms has been parsed.
```
3. Degree of unsaturation calculator:
    - Input a chemical formula to determine its degree of unsaturation.
    - Supports elements like Carbon, Hydrogen, Nitrogen, Oxygen, and halogens.

## Controls
- Right click closes a tab which are shown in the top-left side of the app.
- Clicking the clipboard copies a result computed.

## Contributing
**This project is no longer under active development.**

## Thank you to
- Rareș Niță (https://github.com/raresnita) for proposed UI layout and testing
- Lazăr Ionuț Radu (https://github.com/Lazar-Ionut-Radu) for testing
- Drugea Diana for app logo

***Special thank you to my high school computer science teacher Nicolae Olaroiu for mentoring me.***


