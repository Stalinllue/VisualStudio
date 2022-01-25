using System;

namespace PruebaVSII
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff Pablo = new Staff { firstName = "Pablo", 
                lastName= "Marmol",addressID = '1' ,
                email = "Pablo@.com" , storeID = '1', active = '1', 
                userName = "pablo" , password ="pablo123", 
            picture = "car"};
            Staff Rebeca = new Staff
            {
                firstName = "Rebeca",
                lastName = "Josefina",
                addressID = '1',
                email = "Rebeca@.com",
                storeID = '2',
                active = '2',
                userName = "rebeca",
                password = "rebeca123",
                picture = "sirena"
            };
            Staff Stalin = new Staff
            {
                firstName = "Stalin",
                lastName = "Dominguez",
                addressID = '3',
                email = "Stalin@.com",
                storeID = '3',
                active = '3',
                userName = "stalin",
                password = "stalin123",
                picture = "beton II"
            };
            Staff Maria = new Staff
            {
                firstName = "Maria",
                lastName = "Perez",
                addressID = '4',
                email = "Maria@.com",
                storeID = '4',
                active = '4',
                userName = "maria",
                password = "maria123",
                picture = "disco"
            };
            Staff Carlos = new Staff
            {
                firstName = "Carlos",
                lastName = "Tiban",
                addressID = '5',
                email = "Carlos@.com",
                storeID = '5',
                active = '5',
                userName = "carlos",
                password = "carlos123",
                picture = "betoven"
            };
            Staff Diana = new Staff
            {
                firstName = "Diana",
                lastName = "Loor",
                addressID = '6',
                email = "Diana@.com",
                storeID = '6',
                active = '6',
                userName = "diana",
                password = "diana123",
                picture = "Letty"
            };
            Payment sirenita = new Payment {costomerID ='1', staffID = '1', rentalID = '1' };
            Payment betonben = new Payment { costomerID = '1', staffID = '1', rentalID = '2' };
            Payment roboot = new Payment { costomerID = '1', staffID = '2', rentalID = '3' };
            Payment pezflix = new Payment { costomerID = '1', staffID = '2', rentalID = '4' };
            Payment drrom = new Payment { costomerID = '1', staffID = '3', rentalID = '5' };
            Payment scii = new Payment { costomerID = '1', staffID = '4', rentalID = '6' };
            Payment sholl = new Payment { costomerID = '1', staffID = '5', rentalID = '7' };
            Payment vienos = new Payment { costomerID = '1', staffID = '6', rentalID = '8' };
            Payment ratt = new Payment { costomerID = '1', staffID = '1', rentalID = '9' };
            Payment sirect = new Payment { costomerID = '1', staffID = '3', rentalID = '1' };


            Address Marin = new Address {address= "centro", address2 = "puebla" , district = "Quito", cityID= '1', postalCod = '1', phone = "925351234",  };
            Address SanRoque = new Address { address = "centro", address2 = "puebla", district = "Quito", cityID = '2', postalCod = '1', phone = "925351534", };
            Address Tejar = new Address { address = "centro", address2 = "puebla", district = "Quito", cityID = '3', postalCod = '1', phone = "9253511236", };
            Address Conocoto = new Address { address = "centro", address2 = "puebla", district = "Quito", cityID = '4', postalCod = '1', phone = "9253515234", };
            Address Carolina = new Address { address = "centro", address2 = "puebla", district = "Quito", cityID = '5', postalCod = '1', phone = "9253511524", };

           
        }
    }
}
