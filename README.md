"# WCFServicePractice" 

Windows Communication Foundation (WCF) is the name of the API designed specifically for the process of building distribute system. WCF provides a signle, unified, and extendable programming object model that you can use to interact with a number of previously diverse distributed technologies.

The Role of WCF

WCF is distributed computing toolkit that integrates these independent distributed technologies into a streamlined API represented primarily by the System.ServiceModel namespace. You can expose these service with HTTP ans SOAP to allow external callers to leverage its functionality, regardless of the programming language or operating system.

An Overview of Service-Oriented Architecture (SOA)

SOA is a way to design a distributed system where serveral autonomous services work in conjunction by passing messages across boundaries (network or two proceeses on the same machine) using well-defined interfaces.

Tenet 1. Boundaries are explicit
Tenet 2. Services are autonomous
Tenet 3. Services communicate via contract, not implementation
Tenet 4. Service compatibility is base on policy

WCF makes considerable use of XML-based configuration files, .NET attributes, and proxy generation utilities. The overall process of building WCF is using both TCP- and HTTP- based (e.g. web services) protoccols.

The Basic Composition of a WCF Application

The WCF Service assembly   
This *.dll contains the class and interfaces that represent the overall functionality to expose to external callers.

The WCF Service Host
This software module is the entity that hosts the WCF service assembly.

The WCF client
This is the application that accesses the service's functionality through an intervening proxy.


The ABCs of WCF

Address: This describes the location of the service, it's a System.Uri type
Binding: WCF uses many different bindings that specify network protocols, encoding mechanisms, and the transport layer.
Contract: This provides a description of each method exposed from the WCF service

Understanding WCF Contracts
This is the key to building a WCF service. Interfaces that represent a WCF contract are called service contracts. The classes that implement them are called service types. To build a complete WCF service using [ServiceContract] and [OperationContract] attributes.

Understanding WCF Bindings
A WCF binding can specify the following characteristics:
The transport layer used to transmit data (HTTP, MSMS, named pipe, REST, WebSockets, and TCP);
The channels used by the transport (one-way, request-reply, duplex);
The encoding mechanism used to deal with the data itself such as XML or binary;
Any supported web service protocols (if permitted by the binding).

HTTP-Based Bindings
The BasicHttpBinding, WSHttpBinding, WSDualHttpBinding, and WSFederationHttpBinding options are
geared toward exposing contract types through HTTP/SOAP protocols.

TCP-Based Bindings
TCP-Basing Bindings can gain higher performance that all data is encoded in a compact binary format, rather than XML.

MSMQ-Based Bindings
The NetMsmqBinding and MsmqIntegrationBinding bindings are using Microsoft MSMQ server.

Understanding WCF Addressing
Scheme: This is the transport protocols (e.g. HTTP)
MachineName: 
Port:
Path: The path to the WCF service.

scheme://<MachineName>[:Port]/Path
such as:
http://localhost:8080/MyWCFService or net.tcp://localhost:8080/MyWCFService or net.msmq://localhost/private$/MyPrivateQ

>>>>>>Run the Host as administration role




