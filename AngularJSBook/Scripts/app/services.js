
(function() {
    var app = angular.module('app.services', []);
    app.factory('bookService', ['$http', function($http) {


            var insert = function(book) {

            };


            var getAll = function () {

                var books = $http.get('/api/books');
                return books;

            };

            var getById = function(id) {
                var book = $http.get('/api/books/' + id);
                return book;
            };


            return {
                getById: getById,
                insert: insert,
                getAll: getAll
            };

        }
    ]);
    app.factory('authorService', ['$http', function ($http) {


    var insert = function (author) {

    };

    var getAll = function () {

        var authors = $http.get('/api/authors');
        return authors;

    };

    var getById = function (id) {
        var author = $http.get('/api/authors/'+id);
        return author;
    };

    return {
        getAll: getAll,
        getById: getById,
        insert: insert,


    };

}]);

})();