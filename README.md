# Hair Salon

#### _A C# .NET web application for tracking hair salon stylists and their clients - August 9, 2019_

#### _By **Lisa Jensen**_

## Description

_This web application allows the user to keep track of a hair salon's stylists and their clients._

## Setup/Installation Requirements

* _Clone the following github repository to view the code https://github.com/LisaMJensen/Salon  ._

* Using MySQL:

> CREATE DATABASE lisa_jensen;
> USE lisa_jensen;
> CREATE TABLE stylists (StylistId serial PRIMARY KEY, Name VARCHAR(255));
> CREATE TABLE clients (ClientId serial PRIMARY KEY, StylistId serial default 0, Name VARCHAR(255));

## Known Bugs
* No known bugs at this time.

## Technologies Used

* _C#._
* _.NET_
* _MySQL_

## Support and contact details

_Please reach out to Lisa Jensen with any questions or concerns._

### License

*This application is licensed under the MIT license*

Copyright (c) 2019 **_Lisa Jensen_**
