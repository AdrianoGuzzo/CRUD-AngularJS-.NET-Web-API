app.service('rate', function () {
    this.Rates = function (scope) {
        return [
        {
            title: 'Ionic',
            id: 'Ionic',
            model: findTypeTechnologye(0, scope),
            isRequired: true
        },
        {
            title: 'Android',
            id: 'Android',
            model: findTypeTechnologye(1, scope),
            isRequired: true
        },
        {
            title: 'IOS',
            id: 'IOS',
            model: findTypeTechnologye(2, scope),
            isRequired: true
        },
        {
            title: 'HTML',
            id: 'HTML',
            model: findTypeTechnologye(3, scope),
            isRequired: false
        },
        {
            title: 'CSS',
            id: 'CSS',
            model: findTypeTechnologye(4, scope),
            isRequired: false
        },
        {
            title: 'Bootstrap',
            id: 'Bootstrap',
            model: findTypeTechnologye(5, scope),
            isRequired: true
        },
        {
            title: 'Jquery',
            id: 'Jquery',
            model: findTypeTechnologye(6, scope),
            isRequired: false
        },
        {
            title: 'AngularJs',
            id: 'AngularJs',
            model: findTypeTechnologye(7, scope),
            isRequired: true
        },
        {
            title: 'Java',
            id: 'Java',
            model: findTypeTechnologye(8, scope),
            isRequired: false
        },
        {
            title: 'Asp.Net MVC',
            id: 'AspNetMVC',
            model: findTypeTechnologye(9, scope),
            isRequired: true
        },
        {
            title: 'C',
            id: 'C',
            model: findTypeTechnologye(10, scope),
            isRequired: false
        },
        {
            title: 'C++',
            id: 'C++',
            model: findTypeTechnologye(11, scope),
            isRequired: false
        },
        {
            title: 'Cake',
            id: 'Cake',
            model: findTypeTechnologye(12, scope),
            isRequired: false
        },
        {
            title: 'Django',
            id: 'Django',
            model: findTypeTechnologye(13, scope),
            isRequired: false
        },
        {
            title: 'Majento',
            id: 'Majento',
            model: findTypeTechnologye(14, scope),
            isRequired: false
        },
        {
            title: 'PHP',
            id: 'PHP',
            model: findTypeTechnologye(15, scope),
            isRequired: true
        },
        {
            title: 'Wordpress',
            id: 'Wordpress',
            model: findTypeTechnologye(16, scope),
            isRequired: true
        },
        {
            title: 'Phyton',
            id: 'Phyton',
            model: findTypeTechnologye(17, scope),
            isRequired: false
        },
        {
            title: 'Ruby',
            id: 'Ruby',
            model: findTypeTechnologye(18, scope),
            isRequired: false
        },
        {
            title: 'My SQL Server',
            id: 'MySQLServer',
            model: findTypeTechnologye(19, scope),
            isRequired: false
        },
        {
            title: 'My SQL',
            id: 'MySQL',
            model: findTypeTechnologye(20, scope),
            isRequired: false
        },
        {
            title: 'Salesforce',
            id: 'Salesforce',
            model: findTypeTechnologye(21, scope),
            isRequired: false
        },
        {
            title: 'Photoshop',
            id: 'Photoshop',
            model: findTypeTechnologye(22, scope),
            isRequired: false
        },
        {
            title: 'Illustrator',
            id: 'Illustrator',
            model: findTypeTechnologye(23, scope),
            isRequired: false
        },
        {
            title: 'SEO',
            id: 'SEO',
            model: findTypeTechnologye(24, scope),
            isRequired: false
        }
        ];
    }
    var findTypeTechnologye = function (type, scope) {
        for (var i in scope.talent.Rates) {
            if (scope.talent.Rates[i].TypeTechnology == type)
                return scope.talent.Rates[i];

        }
        return scope.talent.Rates[scope.talent.Rates.push({ TypeTechnology: type, Rate: null }) - 1];
    }
});