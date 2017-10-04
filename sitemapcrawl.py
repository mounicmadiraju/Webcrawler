from BeautifulSoup import BeautifulSoup
import requests
url = raw_input("URL : ")
r = requests.get("url/sitemap.xml")
data = r.text
soup = BeautifulSoup(data)
for link in soup.find_all('a'):
print(link.get('href'))
