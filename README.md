# Dictionary generator
Simple tool for my game which converts csv data table to JSON file.

![](https://user-images.githubusercontent.com/42281413/99908818-12d4c900-2ce5-11eb-9bb7-1fdb81f9b73b.png)

![](https://user-images.githubusercontent.com/42281413/99908882-8f67a780-2ce5-11eb-8b01-119b10c2ee76.png)


## Structure of CSV file
| Spanish| English |
|--|--|
| álgebra | algebra |
| arte| art|

**Note**
The file does not actually have headers 'Spanish' and 'English'.

## JSON file
```json
[
  {
    "Spanish": "álgebra",
    "English": "algebra"
  },
  {
    "Spanish": "arte",
    "English": "art"
  }
]
``` 

## Third party packages
[Newtonsoft JSON](https://www.newtonsoft.com/json)
