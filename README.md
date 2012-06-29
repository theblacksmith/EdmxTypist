# Edmx Typist

A cyber typist which will help you fix your edmx files. It formats the names of Entities, properties and more on a configurable, automated way. 

[![Click here to lend your support to: Edmx Typist and make a donation at www.pledgie.com !](http://www.pledgie.com/campaigns/17089.png?skin_name=chrome)][pledgie]

## Have your ever...

Started a project using Entity Framework with a Database First approach? Did it have a messy, or just not your style, database table and column names? Let's say something like..

    tbl_user
      user_id
      dt_creation
    
    tbl_posts
      post_id
      fk_user_id
      txt_content
      
And you had to manually edit your entites to have something like…

    User
      Id
      CreationDate
    
    Posts
      Id
      UserId
      Content
      
Well, if you knew Edmx Typist back then you wouldn't have to :)

## An image is worth more than… 

<a href="images/screenshot.png" target="_blank">
  <img src="http://projects/static/EdmxTypist/images/screenshot.png" style="width: 600px" />
</a>

## Let's have the words anyway! So, what can you do with it?

You can...

* Add prefixes or suffixes
* Remove prefixes and suffixes
* Apply a regular expression find and replace
* Change the casing to CamelCase, lowerCamelCase or underscore_style
* Pluralize and singularize names in English or Portuguese
* Ask Typist to decide wheter the name should be pluralized or singularized based on the amount of values it represents.

    For example, a navigation property to a single User instance will be singularized while a navigation property to a List<Post> will be pluralized.
    
* Oh, and you can set any of this things to a specific meta-type (eg. for entity sets, comples properties, methods, etc.)

And, if that isn't enough you can…

* Implement a custom flexing rules class using [Flexer][] to support your language
* Create **Your Own Renamer** extending the [IRenamer interface][] to specify your own weird rules :)

[Flexer]: http://github.com/svallory/Flexer
[IRenamer interface]: https://github.com/svallory/EdmxTypist/blob/master/EdmxTypist/Renamer/IRenamer.cs

## Want to Help?

In the spirit of [free software][freesw], **everyone** is encouraged to help
improve this project.

[freesw]: http://www.fsf.org/licensing/essays/free-sw.html

Here are some ways **you** can contribute:

* Coding (just fork, code and make a pull request. Common, it's easy...)
* Reporting [issues][]
* Suggesting [new features][issues]
* Writing [documentation][wiki] (we really need it)
* [Financially][pledgie]

[pledgie]: http://www.pledgie.com/campaigns/17089
[issues]: https://github.com/svallory/EdmxTypist/issues
[wiki]: https://github.com/svallory/EdmxTypist/wiki