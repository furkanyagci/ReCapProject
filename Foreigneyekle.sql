ALTER TABLE Cars
ADD CONSTRAINT CategoryId
FOREIGN KEY (CategoryId) REFERENCES Categories(Id);

--Tabloya ikincil anahtar ekleme kodu