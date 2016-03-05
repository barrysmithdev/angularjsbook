(function() {

    angular.module('app', ['ngRoute', 'app.services', 'app.directives', 'app.controllers']).config(function($routeProvider) {

        $routeProvider.when('/home', {
            templateUrl: 'app/home.html',
            controller: 'HomeController'
         
            })
            .when('/addbook',
                {
                    templateUrl: 'app/book/addupdatebook.html',
                    controller: 'AddUpdateBookController',
                    controllerAs: 'vm'
                
                }
            )
             .when('/editbook/:id',
                {
                    templateUrl: 'app/book/addupdatebook.html',
                    controller: 'AddUpdateBookController',
                    controllerAs: 'vm'
           
                }
            )
             .when('/viewbooks',
                {
                    templateUrl: 'app/book/viewbooks.html',
                    controller: 'ViewBooksController',
                    controllerAs: 'vm'
            
                }
            )
             .when('/viewauthors',
                {
                    templateUrl: 'app/book/viewauthors.html',
                    controller: 'ViewAuthorsController',
                    controllerAs: 'vm'
          
                }
            )
            .otherwise({ redirectTo: '/home' });


    });
})();