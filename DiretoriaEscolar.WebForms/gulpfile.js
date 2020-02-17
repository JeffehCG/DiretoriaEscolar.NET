/// <binding AfterBuild='default, build-css' />
var gulp = require('gulp'),
    sass = require('gulp-sass');

gulp.task('build-css', function () {
    return gulp
        .src('./SASS/**/*.scss')
        .pipe(sass())
        .pipe(gulp.dest('./CSS'));
});

gulp.task('default', ['build-css']);

// Para converter o Sass em css, clique com o botão direito no arquivo .js e Task Runner Explore
// Clique com o botão direito em cima de uma task, troque bindings para after build
// Em seguida clique duas vezes em cima da task desejada