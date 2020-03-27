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
