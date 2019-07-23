// Please enter your bootstrap version here. bs4 = bootstrap 4, bs3 = bootstrap 3.
const cssFramework = 'bs4';
// Enter the name of your app here. Use all lowercase lettering.
const appname = 'mobiusforms';

const path = require('path');
const MiniCssExtractPlugin = require('mini-css-extract-plugin');
const OptimizeCSSAssetsPlugin = require('optimize-css-assets-webpack-plugin');
const FriendlyErrorsWebpackPlugin = require('friendly-errors-webpack-plugin');
const WebpackBar = require('webpackbar');

module.exports = env => {
  
  return {
    entry: ['./src/scss/' + cssFramework + '.scss', './src/ts/main.ts'],
    mode: 'production',
    devtool: 'source-map',
    stats: {
      all: false,
      assets: true
    },
    output: {
      path: path.resolve(__dirname, 'live/dist'),
      filename: 'app-bundle.min.js',
      library: appname,
    },
    resolve: {
      extensions: ['.ts', '.tsx', '.js', '.scss']
    },
    module: {
      rules: [{
          test: /\.scss$/i,
          exclude: /node_modules/,
          use: [
            MiniCssExtractPlugin.loader,
            {
              loader: 'css-loader'
            }, {
              loader: 'sass-loader',
            }
          ]
        },
        {
          test: /\.ts?$/,
          exclude: /node_modules/,
          use: 'ts-loader',
        },
        {
          test: /\.(png|jpe?g|gif)$/,
          use: [{
              loader: 'file-loader',
              options: {
                  name: '[name].[ext]',
                  outputPath: 'images/'
              }
          }]
        }
      ],
    },
    optimization: {
      minimizer: [
        new OptimizeCSSAssetsPlugin({ 
          cssProcessorOptions: { 
            map: { 
              inline: false, 
              annotation: true, 
            } 
          } 
        })
      ],
    },
    plugins: [
      new MiniCssExtractPlugin({
        filename: 'style.min.css'
      }),
      new WebpackBar(),
      new FriendlyErrorsWebpackPlugin(),
    ]
  };
};