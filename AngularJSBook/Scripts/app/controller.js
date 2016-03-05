
(function() {

    var app = angular.module('app.controllers', []);

    app.controller('HomeController', function() {


    });
    app.controller('AddUpdateBookController', ['$scope', '$routeParams', 'bookService', 'authorService', function ($scope, $routeParams, bookService, authorService) {

                //  $scope.editableBook = angular.copy($scope.book);

        var vm = this;

        authorService.getAll().then(
                  function success(results) {
                      // on success
                      vm.authors = results.data;
                  },
                  function failure(results) {
                      // on error
                      vm.error = results.data;
                  }
              );

            if ($routeParams.id) {
                bookService.getById($routeParams.id).then(function (result) {
                    vm.book = result.data;
                    vm.editableBook = angular.copy(vm.book);
                    vm.editableBook.author = vm.authors[1];
                });
            } else {
                vm.book = { id: 0 };
            }

          

          
                //    [
                //    { name: 'tom davies', id: '1' },
                //    { name: 'moses', id: '2' },
                //    { name: 'john skeet', id: '3' },
                //    { name: 'eric schmidt', id: '4' }

                //];


            vm.submitForm = function () {

                if (!vm.addBookForm.$valid) {
                        $log.warn('book invalid');
                        return;
                    }

                bookService.insert(vm.editableBook);

                    // $scope.book = angular.copy($scope.editableBook);
                    //$window.history.back();
                };


            vm.cancelForm = function () {
                    $window.history.back();
                };

            }
    ]);

    app.controller('ViewBooksController', ['$scope', 'bookService', function ($scope, bookService) {


        var vm = this;

        vm.handleEmitEvent = function () {

            vm.$emit('someEmitEvent', function () { return 10; });

        };


        vm.showUnPublished = true;
        var tempBooks = [];

        bookService.getAll().then(function (result) {
            vm.books = result.data;
            tempBooks = vm.books.slice();
        });

        vm.filterPublished = function (value) {

            if (vm.showUnPublished === false) {
                vm.books.forEach(function (entry) {
                    if (entry.isPublished === false) {
                        var index = vm.books.indexOf(entry);
                        vm.books.splice(index, 1);
                    }
                });
            }
            else {
                vm.books = tempBooks;
            }


        };
 }]);


})();
