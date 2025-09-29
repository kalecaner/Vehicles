# 🚘 Vehicles
_A simple educational project to manage vehicle records (CRUD), designed for learning and personal development._

Bu proje, **araç kayıtlarını** yönetmek (CRUD) için hazırlanmış basit bir örnek uygulamadır.  
**Tamamen eğitim ve kişisel gelişim amaçlıdır.**

This project is a simple sample app to manage **vehicle records** (CRUD).  
**It is purely for educational and personal-development purposes.**

---

## 🎯 Projenin Amacı / Project Purpose

**TR**
- .NET ile katmanlı, okunabilir ve test edilebilir bir yapıyı pratik etmek  
- Basit CRUD akışları (Araç ekleme, listeleme, güncelleme, silme) uygulamak  
- Temel doğrulama, eşleme (mapping) ve veri erişimini deneyimlemek  

**EN**
- Practice layered, readable, and testable structure with .NET  
- Implement basic CRUD flows (Create/Read/Update/Delete vehicles)  
- Get hands-on with validation, mapping, and data access fundamentals  

---

## 🏗 Mimari Genel Bakış / Architecture Overview

**TR**
- **Domain / Core**: Temel entity ve iş kuralları  
- **Application**: Use-case’ler (komut/sorgu), DTO’lar, validasyon  
- **Infrastructure**: Veri erişim (örn. EF Core/Dapper), dış bağımlılıklar  
- **Presentation**: REST API (Controllers/Minimal API)

**EN**
- **Domain / Core**: Core entities and business rules  
- **Application**: Use-cases (commands/queries), DTOs, validation  
- **Infrastructure**: Data access (e.g., EF Core/Dapper), external deps  
- **Presentation**: REST API (Controllers/Minimal API)

> Not/Note: Bu iskelet eğitim amaçlıdır; gerçek projede güvenlik, logging, caching, exception handling, transaction yönetimi gibi konular detaylandırılmalıdır.  
> This is an educational skeleton; production apps should add security, logging, caching, exception handling, transaction management, etc.

---

---

## 🛠 Kullanılan Teknolojiler / Technologies

- **.NET 8 / ASP.NET Core Web API**  
- **Entity Framework Core** veya **Dapper** (kullanımına göre)  
- **FluentValidation** (doğrulama)  
- **AutoMapper** (DTO ↔ Entity eşleme)  
- **Swagger / OpenAPI** (dokümantasyon)  
- **xUnit / NUnit / MSTest** (test)

> Senin repoya göre paket adlarını/versiyonlarını ekleyebilirsin.  
> Add exact package names/versions as per your repo.

---



## 📂 Proje Yapısı / Project Structure

