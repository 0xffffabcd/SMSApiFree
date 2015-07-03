# SMSApiFree

This is an API client for the Free.fr SMS notification service.

This will allow you to send an SMS to your own number using Free.fr notification service.

## Limitations

* You must be a subsriber of [Free](http://mobile.free.fr/)
* You must enable the [notification option](https://mobile.free.fr/moncompte/)
* You can only send text to your own number (hence the "notification")

## Projects

The solution includes two projects:

### FreeSMSLib

Class library that acts as the API client

### SMSSenderDemo

Demo WinForms application using the class library