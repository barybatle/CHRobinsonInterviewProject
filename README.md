WebAPI created for C.H Robinson tech interview

Made in .NET 5.0

This API receives country code and returns object with destination country and list of all countries that you need to visit in order to reach the destination.

Default starting locations is USA.

App is deployed in Azure under adress https://chrobinsoninterview.azurewebsites.net, if you visit it it will return 404 as I didn't make any frontend for this project. 

# Usage

Request GET to https://chrobinsoninterview.azurewebsites.net/{CODE} where {CODE} is three letter code of country you are willing to set destination to

List of valid contry codes:  "CAN", "USA", "MEX", "BLZ", "GTM", "SLV", "HND", "NIC", "CRI", "PAN"

When you input invalid code it will return 404

Example:

GET on https://chrobinsoninterview.azurewebsites.net/BLZ should return:

```json
{
    "destination": "BLZ",
    "list": [
        "USA",
        "MEX",
        "BLZ"
    ]
}
```

I've also added Swagger to the project so you can test it more easily 
