app.controller('hr.vendors',
    function ($scope, $modal, $animate, ngCrud, $http, ngDialog, myResource, $timeout) {
        $scope.templates =
            [{ name: 'Vendors', url: '/hr/vendorsList' },
             { name: 'Add New Vendor', url: '/hr/addVendor' }];
        $scope.template = $scope.templates[0];

        $scope.myData = [
  {
      "Name": "Tiger Nixon",
      "City": "Pune",
      "Address": "Edinburgh",
      "Phone": "9937363733",
      "Email": "robert@gmail.com",
      "Gender": "Male",
      "Vendor Type": "Water Supply",
      "Vendor Head": ""
  },
  {
      "Name": "Tiger Nixon",
      "City": "Pune",
      "Address": "Edinburgh",
      "Phone": "9937363733",
      "Email": "robert@gmail.com",
      "Gender": "Male",
      "Vendor Type": "Water Supply",
      "Vendor Head": ""
  },
  {
      "Name": "Tiger Nixon",
      "City": "Pune",
      "Address": "Edinburgh",
      "Phone": "9937363733",
      "Email": "robert@gmail.com",
      "Gender": "Male",
      "Vendor Type": "Water Supply",
      "Vendor Head": ""
  },
  {
      "Name": "Tiger Nixon",
      "City": "Pune",
      "Address": "Edinburgh",
      "Phone": "9937363733",
      "Email": "robert@gmail.com",
      "Gender": "Male",
      "Vendor Type": "Water Supply",
      "Vendor Head": ""
  },
  {
      "Name": "Tiger Nixon",
      "City": "Pune",
      "Address": "Edinburgh",
      "Phone": "9937363733",
      "Email": "robert@gmail.com",
      "Gender": "Male",
      "Vendor Type": "Water Supply",
      "Vendor Head": ""
  },
  {
      "Name": "Tiger Nixon",
      "City": "Pune",
      "Address": "Edinburgh",
      "Phone": "9937363733",
      "Email": "robert@gmail.com",
      "Gender": "Male",
      "Vendor Type": "Water Supply",
      "Vendor Head": ""
  },
  {
      "Name": "Tiger Nixon",
      "City": "Pune",
      "Address": "Edinburgh",
      "Phone": "9937363733",
      "Email": "robert@gmail.com",
      "Gender": "Male",
      "Vendor Type": "Water Supply",
      "Vendor Head": ""
  },
  
        ];
    }
);

