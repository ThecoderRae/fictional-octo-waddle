### This is a simple web API which returns to the client some user data.

### The API relies on an external web service accessible over http to retrieve that user data.

### The client, like a proxy, makes a request to "Us" for the user data and "under the hood" the API will reach out to some third-party customer service, making http requests to that service, getting some data back and serialising it in such a way that is it useful for the clients and returning that particular customer data back as json to the API clients.

### It is sort of a simple proxy to an external service, where the API sits between the clients and the third-party customer data service.
