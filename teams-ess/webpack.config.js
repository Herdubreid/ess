const path = require('path');

module.exports = {
    entry: './JS/main.js',
    output: {
        path: path.join(__dirname, 'wwwroot'),
        filename: "main.js",
        library: 'TeamsFx'
    },
    resolve: {
        extensions: ['.js'],
        mainFields: ['browser', 'module', 'main']
    },
    module: {
        rules: [
            {
                test: /node_modules/,
                use: [
                    'ify-loader'
                ]
            }
        ]
    }
};
