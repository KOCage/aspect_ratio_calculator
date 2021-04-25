# aspect_ratio_calculator
My partner asked for an application that would calculate aspect ratio for jumprings. 

The requested features: 
```
Basic: 
  Program to perform the following calculation:
  Inner diameter of ring / wire diameter (also called gauge) = aspect ratio
  ID / WD = AR
  
  Two inputs
    WD first - wire diameter assumed to be AWG for aluminum
    ID second - assumed to be inches, would prefer to enter this as a fraction
    
  Program would need to convert AWG to inches in order to return the correct AR
```
```
Further Asks: 
  Two inputs
    WD first - Able to select the unit of measure
    ID second - Able to select the unit of measure
    
  Program would neeed to convert WD to match ID in order to return correct AR
```
```
The Dream:
  Given any two variables from the requestion ID/WD=AR, returns values for the third. 
  
  When returning ID, return a value for actual calculation and nearest standard value. When returing ID as inches, should be a fraction
  
  When returning WD, return nearest AWG and SWG. If not exact, indicate in some way that this was not an exact match
```
