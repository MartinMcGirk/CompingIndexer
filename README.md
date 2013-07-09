Comping Helper
==========

### A tool to help in entering many online competitions quickly and easily

A small C# WinForms application that crawls comping forums and lets the user see which competitions are available and then navigate to the competition website without needing to trawl through endless forum pages.


### Instructions:

1. Grab the code, compile and run 
2. Pick a number of forum pages to crawl using the numeric up-down
3. Press start to populate the listbox with available competitions
4. Select a competition from the list to bring up the relevant website


### Future improvements

1. AutoFill forms
2. Use a database to cache previously retrieved competitions and prevent unnecessary crawling of the forums
3. Hive off the crawling to a Web service which could crawl every half hour, cache and then serve up info as required.
4. Add more forums to crawl.