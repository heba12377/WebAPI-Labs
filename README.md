# WebAPI


## Requirements

Day1 Requirements : 

- Create a CarsController with all crud on a static list.
- Enable logging and try to log some requests.
- Add a counter that counts the requests and add an endpoint, through which we can get the value of this counter. 
- Add Validation on Car Object to be (ProductionDate to be in  the past only).
- Post method should return the url for the newly added car in the header.
- Add a new property to the Car Model Called Type. Old endpoint should explicitly assign this property with “Gas”. New endpoint should validate that this property can only accept “Electric, Gas, Diesel and Hybrid”.
