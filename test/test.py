constructor(private _http:Http){
        this.url_get_postcodes = "http://inl00528:9090/snippet_list/";
        this.url_getcode_by_lang_type = "http://inl00528:9090/snippets/?lang_type=";
        this.url_getcode_by_code_title = " http://inl00528:9090/snippets/?title=";
        this.url_getlanguages = "http://inl00528:9090/languages/";
        
    }