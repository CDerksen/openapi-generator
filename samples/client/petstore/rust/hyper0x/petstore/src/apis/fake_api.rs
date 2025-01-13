/*
 * OpenAPI Petstore
 *
 * This is a sample server Petstore server. For this sample, you can use the api key `special-key` to test the authorization filters.
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

use std::rc::Rc;
use std::borrow::Borrow;
use std::pin::Pin;
#[allow(unused_imports)]
use std::option::Option;

use hyper;
use futures::Future;

use crate::models;
use super::{Error, configuration};
use super::request as __internal_request;

pub struct FakeApiClient<C: hyper::client::connect::Connect>
    where C: Clone + std::marker::Send + Sync + 'static {
    configuration: Rc<configuration::Configuration<C>>,
}

impl<C: hyper::client::connect::Connect> FakeApiClient<C>
    where C: Clone + std::marker::Send + Sync {
    pub fn new(configuration: Rc<configuration::Configuration<C>>) -> FakeApiClient<C> {
        FakeApiClient {
            configuration,
        }
    }
}

pub trait FakeApi {
    fn test_nullable_required_param(&self, user_name: &str, dummy_required_nullable_param: Option<&str>, uppercase: Option<&str>, content: Option<&str>) -> Pin<Box<dyn Future<Output = Result<(), Error>>>>;
}

impl<C: hyper::client::connect::Connect>FakeApi for FakeApiClient<C>
    where C: Clone + std::marker::Send + Sync {
    #[allow(unused_mut)]
    fn test_nullable_required_param(&self, user_name: &str, dummy_required_nullable_param: Option<&str>, uppercase: Option<&str>, content: Option<&str>) -> Pin<Box<dyn Future<Output = Result<(), Error>>>> {
        let mut req = __internal_request::Request::new(hyper::Method::GET, "/fake/user/{user_name}".to_string())
        ;
        if let Some(ref s) = content {
            let query_value = s.to_string();
            req = req.with_query_param("content".to_string(), query_value);
        }
        req = req.with_path_param("user_name".to_string(), user_name.to_string());
        match dummy_required_nullable_param {
            Some(param_value) => { req = req.with_header_param("dummy_required_nullable_param".to_string(), param_value.to_string()); },
            None => { req = req.with_header_param("dummy_required_nullable_param".to_string(), "".to_string()); },
        }
        if let Some(param_value) = uppercase {
            req = req.with_header_param("UPPERCASE".to_string(), param_value.to_string());
        }
        req = req.returns_nothing();

        req.execute(self.configuration.borrow())
    }

}
