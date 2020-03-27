# demo-xunit-restsharp
POC demonstrative using XUnit and RestSharp for Automation Tests in API Rest

API used for testing: https://github.com/fredmoreira/phone-book

## Juan notes

### Setup phone-book API server

Install dependencies:
```
brew install npm
brew install node
brew install mondodb-community
```

Install the project API:
```
npm install
npm start
```

Start mongodb and the API server:
```
mongod --config /usr/local/etc/mongod.conf --fork
npm start
```

Once this is done, you can run the unit tests on the VS project.

### Description of the web service

This is a web service that implements a book of phone contacts.

Operations:
* Post contact
* Get contact
* Put contact 
* Delete contact

Example of a contact:
```
[{"_id":"56d5efa8c82593800291c02b","name":"Tester","mobilephone":"0552188889999","homephone":"0552133332222"}]i
```
