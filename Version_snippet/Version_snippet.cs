e('../app')

app.factory 'djangoAuth', ($q, $http, $cookies) ->
    class DjangoAuth
        # START CUSTOMIZATION HERE
        # Change this to point to your Django REST Auth API
        # e.g. /api/rest-auth  (DO NOT INCLUDE ENDING SLASH)
        @API_URL = '/rest-auth'
        # Set use_session to true to use Django sessions to store security token.
        # Set use_session to false to store the security token locally and transmit it as a custom header.
        @use_session = true
        # END OF CUSTOMIZATION
        @credentials = null
        @authPromise = null

        @request = (args) ->
            # Let's retrieve the token from the cookie, if available
            if $cookies.token?
                $http.defaults.headers.common.Authorization = 'Token ' + $cookies.token

            params = args.params || {}
            args = args || {}
            deferred = $q.defer()
            url = this.API_URL + args.url
            method = args.method || "GET"
            params = params
            data = args.data